open LLVM.Quote
open LLVM.Generated.Core
open LLVM.Core
open LLVM.Generated.ExecutionEngine
open LLVM.ExecutionEngine
open LLVM.Generated.Target
open LLVM.Generated.BitWriter
open LLVM.BitReader

let testQuote =
    <@
        // let's start with some super-simple functions
        let isEven x = x % 2 = 0

        // simple recursion
        let rec fib = function
            | 0 -> 0
            | 1 -> 1
            | n -> fib (n - 1) + fib (n - 2)

        // mutually recursive function def
        let rec mutRecIsEven = function
            | 0u -> true
            | n  -> mutRecIsOdd (n - 1u)
        and mutRecIsOdd = function
            | 0u -> false
            | n  -> mutRecIsEven (n - 1u)

        // for loop with a mutable
        let fac x : int =
            let mutable sum = 1
            for i = 2 to x do
                sum <- sum * i
            sum

        // simple array with for loop
        let sum (xs:RawArray<int>) (size:int) : int =
            let mutable sum = 0
            for i = 0 to size - 1 do
                sum <- sum + xs.[i]
            sum

        // simple array with while loop
        let sumUsingWhile (xs:RawArray<int>) (size:int) : int =
            let mutable sum = 0
            let mutable i = 0
            while i < size do
                sum <- sum + xs.[i]
                i <- i + 1
            sum

        let sum869() : int =

            // some pointless tuple code
            let tup = (8, 6, 9)
            let x, y, z = tup
            free tup

            // build the array and call sum
            let size = 3
            let arr = heapAllocRawArray size
            arr.[0] <- x
            arr.[1] <- y
            arr.[2] <- z
            let result = sum arr size
            free arr

            result

        // simple array with for loop
        let sumDoubles (xs:RawArray<double>) (size:int) : double =
            let mutable sum = 0.0
            for i = 0 to size - 1 do
                sum <- sum + xs.[i]
            sum

        let sumDoublesOnStack() : double =

            // build the array and call sum
            let size = 3
            let arr = stackAllocRawArray size
            arr.[0] <- 8.5
            arr.[1] <- 6.5
            arr.[2] <- 9.5
            let result = sumDoubles arr size

            result

        let makeArr() : RawArray<int> =

            // some pointless tuple code
            let tup = (8, 6, 9)
            let x, y, z = tup
            free tup

            // build the array and call sum
            let size = 3
            let arr = heapAllocRawArray size
            arr.[0] <- x
            arr.[1] <- y
            arr.[2] <- z
            arr

        ()
    @>

let linAlgQuote =
    <@
        let transpose (squareMat:RawArray<double>) (rowColCount:int) : unit =
            for row = 0 to rowColCount - 1 do
                for col = row + 1 to rowColCount - 1 do
                    let index1 = row * rowColCount + col
                    let index2 = col * rowColCount + row

                    let tmp = squareMat.[index1]
                    squareMat.[index1] <- squareMat.[index2]
                    squareMat.[index2] <- tmp

        let dotProdRowCol
                (m1:RawArray<double>) numCols1
                (m2:RawArray<double>) numCols2
                row col =
            let mutable dotProd = 0.0
            for i = 0 to numCols1 - 1 do
                dotProd <- dotProd + m1.[row * numCols1 + i] * m2.[i * numCols2 + col]
            dotProd

        let matMult (m1:RawArray<double>) numRows1 numCols1 (m2:RawArray<double>) numCols2 =
            let matMulResult = heapAllocRawArray (numRows1 * numCols2)
            for row = 0 to numRows1 - 1 do
                let rowOffset = row * numCols2
                for col = 0 to numCols2 - 1 do
                    matMulResult.[rowOffset + col] <- dotProdRowCol m1 numCols1 m2 numCols2 row col
            matMulResult

        let reorderArray (arr : RawArray<double>) (order : RawArray<int>) (len:int) =
            let tempArr = heapAllocRawArray len
            for i = 0 to len - 1 do
                tempArr.[i] <- arr.[order.[i]]
            for i = 0 to len - 1 do
                arr.[i] <- tempArr.[i]
            free tempArr

        let reorderMatrixRows (matrix:RawArray<double>) (rowOrder:RawArray<int>) size : unit =
            let sizeSq = size * size
            let tempMat = heapAllocRawArray sizeSq
            for i = 0 to sizeSq - 1 do
                tempMat.[i] <- matrix.[i]
            for row = 0 to size - 1 do
                let row2 = rowOrder.[row]
                if row <> row2 then
                    let offset1 = row * size
                    let offset2 = row2 * size
                    for col = 0 to size - 1 do
                        matrix.[offset1 + col] <- tempMat.[offset2 + col]
            free tempMat

        let abs x = if x >= 0.0 then x else -x
        let isNearZero x =
            let nearZero = 1e-8
            x < nearZero && x > -(nearZero)

        /// <summary>
        /// Use guassian elimination with pivoting to calculate LU decomposition for the
        /// given matrix. Since pivoting changes row ordering the reordered indices are
        /// also returned.
        /// </summary>
        /// <param name="m">the coefficient matrix (must be square)</param>
        /// <returns>
        /// A tuple containing: (luMatrix, rowOrder). The upper triangle of luMatrix
        /// (including diagonal) contains U while the lower triangle of luMatrix
        /// contains L
        /// </returns>
        let luDecompose (matrix:RawArray<double>) (size:int) : RawArray<int> =
            //let size = Array2D.length1 matrix

            //let rowOrder = [|0 .. size - 1|]
            let rowOrder = heapAllocRawArray size
            for i = 0 to size - 1 do
                rowOrder.[i] <- i

            for diagIndex = 0 to size - 2 do
                // perform "partial pivoting" which bubbles the max absolute coefficient
                // to the top (improves algorithm's accuracy)
                let mutable maxIndex = diagIndex
                let mutable maxAbsCoef = abs matrix.[rowOrder.[diagIndex] * size + diagIndex]
                for j = diagIndex + 1 to size - 1 do
                    let currAbsVal = abs matrix.[rowOrder.[j] * size + diagIndex]
                    if currAbsVal > maxAbsCoef then
                        maxAbsCoef <- currAbsVal
                        maxIndex <- j

                // now swap the max row with the current
                if maxIndex <> diagIndex then
                    let tmp = rowOrder.[diagIndex]
                    rowOrder.[diagIndex] <- rowOrder.[maxIndex]
                    rowOrder.[maxIndex] <- tmp

                // now "zero out" the coefficients below the diagonal
                let diagCoef = matrix.[rowOrder.[diagIndex] * size + diagIndex]
                for row = diagIndex + 1 to size - 1 do
                    let orderedRow = rowOrder.[row]
                    let currCoef = matrix.[orderedRow * size + diagIndex]
                    let zeroFactor = currCoef / diagCoef
                    if not (isNearZero zeroFactor) then
                        for col = diagIndex + 1 to size - 1 do
                            matrix.[orderedRow * size + col] <-
                                matrix.[orderedRow * size + col] -
                                (zeroFactor * matrix.[rowOrder.[diagIndex] * size + col])
                    matrix.[orderedRow * size + diagIndex] <- zeroFactor
    
            reorderMatrixRows matrix rowOrder size
            rowOrder

        // solve a matrix that is zeroed out below the diagonal using
        // back substitution
        let backSubstituteUpper
                (upperTriangleMat:RawArray<double>)
                (rhsVec:RawArray<double>)
                (size:int)
                : RawArray<double> =

            let solution = heapAllocRawArray size
            for i = 0 to size - 1 do
                solution.[i] <- 0.0

            //for i = size - 1 downto 0 do
            let mutable i = size - 1
            while i >= 0 do
                let rowOffset = i * size
                let mutable sum = 0.0
                //for j = n - 1 downto i + 1 do
                let mutable j = size - 1
                while j >= i + 1 do
                    sum <- sum + (upperTriangleMat.[rowOffset + j] * solution.[j])
                    j <- j - 1
                solution.[i] <- ((rhsVec.[i] - sum) / upperTriangleMat.[rowOffset + i] : double)
                i <- i - 1
            solution

        let solveLU (luMatrix:RawArray<double>) (rhsVec:RawArray<double>) (size:int) : RawArray<double> =
            for col = 0 to size - 2 do
                for row = col + 1 to size - 1 do
                    rhsVec.[row] <- rhsVec.[row] - (rhsVec.[col] * luMatrix.[row * size + col])
            backSubstituteUpper luMatrix rhsVec size

        let solveWithGaussAndBackSub
                (coefMat:RawArray<double>)
                (rhsVec:RawArray<double>)
                (size:int)
                : RawArray<double> =

            let rowOrder = luDecompose coefMat size
            reorderArray rhsVec rowOrder size
            free rowOrder
            solveLU coefMat rhsVec size

        ()
    @>

[<EntryPoint>]
let main _ =

    let llvmModuleRef = moduleCreateWithName "quote-module"
    compileQuote llvmModuleRef testQuote
    compileQuote llvmModuleRef linAlgQuote
    dumpModule llvmModuleRef
    writeBitcodeToFile llvmModuleRef "quotemodule.bc" |> ignore
    
    // exit success
    0

