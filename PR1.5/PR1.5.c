#include <stdio.h>
#include <stdlib.h>

/*Estancia

ECA: variable de tipo real. */

void main(void)
{
    float ECA;
    printf("Ingrese la extension de la estancia: ");
    scanf("%f", &ECA);
    ECA = ECA * 4047 / 10000;
    printf("nExtension de la estancia en hectareas: %5.2f", ECA);
}
