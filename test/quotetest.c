#include <stdlib.h>
#include <stdio.h>
//#include <stdint.h>

extern int sum869();
extern int sum(int*, int);
extern int sumUsingWhile(int*, int);
extern double sumDoublesOnStack();
extern int* makeArr();
extern double* transpose(double*, int);
extern double* matMult(double*, int, int, double*, int);
extern double* solveWithGaussAndBackSub(double*, double*, int);

void printMat(double* mat, int rowCount, int colCount) {
    int row;
    int col;
    for(row = 0; row < rowCount; row++) {
        for(col = 0; col < colCount; col++) {
            printf("%f\t", mat[row * colCount + col]);
        }
        printf("\n");
    }
}

int main(int argc, const char* argv[])
{
    int i;
    int* arr = makeArr();
    printf("makeArr() -> [%i, %i, %i]\n", arr[0], arr[1], arr[2]);
    
    int xs[] = {8, 6, 9};
    printf("xs -> [%i, %i, %i]\n", xs[0], xs[1], xs[2]);
    printf("sum() -> %i\n", sum(xs, 3));
    printf("sum869() -> %i\n", sum869());
    printf("sumUsingWhile() -> %i\n", sumUsingWhile(xs, 3));
    printf("sumDoublesOnStack() -> %f\n", sumDoublesOnStack());
    
    double sqMat[] = {
        1.0, 2.0, 3.0,
        4.0, 5.0, 6.0,
        7.0, 8.0, 9.0};
    printf("before transpose:\n");
    printMat(sqMat, 3, 3);
    transpose(sqMat, 3);
    printf("after transpose:\n");
    printMat(sqMat, 3, 3);
    printf("\n");
    
    double testMat1[] = {
        2, 0, -1, 1,
        1, 2, 0, 1};
    printMat(testMat1, 2, 4);
    printf("X\n");

    double testMat2[] = {
        1, 5, -7,
        1, 1, 0,
        0, -1, 1,
        2, 0, 0};
    printMat(testMat2, 4, 3);
    printf("=\n");
    double* mmResult = matMult(testMat1, 2, 4, testMat2, 3);
    printMat(mmResult, 2, 3);
    printf("\n");
    
    free(mmResult);
    
    double mCoefMatrix[] = {
        2.0,  1.0, 1.0,
        6.0,  3.0, 1.0,
        -2.0, 2.0, 1.0
    };
    printf("Coefficient Matrix:\n");
    printMat(mCoefMatrix, 3, 3);
    double mRHSVector[] = {1.0, -1.0, 7.0};
    printf("Right Hand Side Vector:\n");
    for(i = 0; i < 3; i++) {
        printf("%f\n", mRHSVector[i]);
    }
    printf("Equation solution:\n");
    double* solution = solveWithGaussAndBackSub(mCoefMatrix, mRHSVector, 3);
    for(i = 0; i < 3; i++) {
        printf("%f\n", solution[i]);
    }
    free(solution);

    return 0;
}
