module LLVM.Core

open System.Runtime.InteropServices
open LLVM.Generated.Core

let functionType (retTy : TypeRef) (paramTys : TypeRef []) =
    let paramTyPtrs = Array.map (fun x -> match x with TypeRef ptr -> ptr) paramTys
    
    let aloc = Marshal.AllocHGlobal (sizeof<nativeint> * paramTys.Length)
    Marshal.Copy (paramTyPtrs, 0, aloc, paramTyPtrs.Length)
    let fType = functionType retTy aloc (uint32 paramTys.Length) false
    Marshal.FreeHGlobal aloc
    
    fType

let getBasicBlocks f =
    let bbCount = countBasicBlocks f
    if bbCount >= 1u then
        let rec goNext i bb =
            if i < bbCount then
                let nextBB = getNextBasicBlock bb
                bb :: goNext (i + 1u) nextBB
            else
                [bb]
        goNext 1u (getFirstBasicBlock f)
    else
        []

