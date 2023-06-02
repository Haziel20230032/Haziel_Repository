#include <stdio.h>
#include <stdlib.h>

/* Incremento de precio.

PRE Y NPR: variable de tipo real. */

void main (void)
{
    float PRE, NPR;
    printf("ingrese el precio del producto: ");
    scanf("%f", &PRE);

    if (PRE < 1500)
    {
        NPR = PRE * 1.11;
        printf("/nNuevo precio: %7.2f",NPR);
    }
}
