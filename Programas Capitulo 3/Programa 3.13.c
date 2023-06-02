#include <stdio.h>
#include <stdlib.h>

void main(void)
{
    int i, pri = 0, seg = 1, sig;

    printf("\t %d \t %d\n", pri, seg);
    for (i = 3; i <= 50; i++)
    {
        sig = pri + seg;
        pri = seg;
        seg = sig;
        printf("\t %d\n", sig);
    }
}
