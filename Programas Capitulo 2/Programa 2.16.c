#include <stdio.h>
#include <stdlib.h>

void main(void)
{
    int CLA, CAT, ANT, RES;

    printf("Ingrese la clave, categor�a y antig�edad del trabajador:\n");
    scanf("%d %d %d", &CLA, &CAT, &ANT);

    switch (CAT)
    {
    case 3:
    case 4:
        if (ANT >= 5)
        {
            RES = 1;
        }
        else
        {
            RES = 0;
        }
        break;
    case 2:
        if (ANT >= 7)
        {
            RES = 1;
        }
        else
        {
            RES = 0;
        }
        break;
    default:
        RES = 0;
        break;
    }

    if (RES)
    {
        printf("El trabajador con clave %d re�ne las condiciones para el puesto\n", CLA);
    }
    else
    {
        printf("El trabajador con clave %d no re�ne las condiciones para el puesto\n", CLA);
    }
}
