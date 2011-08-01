#include <stdlib.h>
#include <stdio.h>

extern int add1(int, int);
extern int add2(int, int);

int main(int argc, const char* argv[])
{
    printf("add1(3, 8) -> %i\n", add1(3, 8));
    printf("add2(3, 8) -> %i\n", add2(3, 8));
    return 0;
}
