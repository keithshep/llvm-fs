#include <stdlib.h>
#include <stdio.h>
//#include <stdint.h>

extern int sum869();
extern int sum(int*, int);
extern int sumUsingWhile(int*, int);
extern int* makeArr();

int main(int argc, const char* argv[])
{
    int* arr = makeArr();
    printf("makeArr() -> [%i, %i, %i]\n", arr[0], arr[1], arr[2]);
    
    int xs[] = {8, 6, 9};
    printf("xs -> [%i, %i, %i]\n", xs[0], xs[1], xs[2]);
    printf("sum869() -> %i\n", sum869());
    printf("sum() -> %i\n", sum(xs, 3));
    printf("sumUsingWhile() -> %i\n", sumUsingWhile(xs, 3));
    
    return 0;
}
