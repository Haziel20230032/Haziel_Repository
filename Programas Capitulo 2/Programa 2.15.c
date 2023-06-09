#include <stdio.h>
#include <stdlib.h>

void main(void)
{
    int TRA, EDA, DIA;
    float COS;

    printf("Ingresa tipo de tratamiento, edad y d�as: ");
    scanf("%d %d %d", &TRA, &EDA, &DIA);

    switch (TRA)
    {
    case 1:
        COS = DIA * 2800.0;
        break;
    case 2:
        COS = DIA * 1950.0;
        break;
    case 3:
        COS = DIA * 2500.0;
        break;
    case 4:
        COS = DIA * 1150.0;
        break;
    default:
        COS = -1;
        break;
    }

    if (COS != -1)
    {
        if (EDA >= 60)
        {
            COS = COS * 0.75;
        }
        else if (EDA <= 25)
        {
            COS = COS * 0.85;
        }
        printf("\nClave tratamiento: %d\t D�as: %d\t Costo total: %8.2f\n", TRA, DIA, COS);
    }
    else
    {
        printf("\nLa clave del tratamiento es incorrecta\n");
    }
}