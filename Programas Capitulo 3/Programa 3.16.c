#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    int i, mat, mamat, memat;
    float sum, pro, cal, mapro = 0.0, mepro = 11.0;

    printf("Ingrese la matr�cula del primer alumno:\t");
    scanf("%d", &mat);

    while (mat)
    {
        sum = 0;
        for (i = 1; i <= 5; i++)
        {
            printf("\tIngrese la calificaci�n del alumno: ", i);
            scanf("%f", &cal);
            sum += cal;
        }

        pro = sum / 5;
        printf("\nMatr�cula:%d\tPromedio:%5.2f", mat, pro);

        if (pro > mapro)
        {
            mapro = pro;
            mamat = mat;
        }

        if (pro < mepro)
        {
            mepro = pro;
            memat = mat;
        }

        printf("\n\nIngrese la matr�cula del siguiente alumno: ");
        scanf("%d", &mat);
    }

    printf("\n\nAlumno con mejor promedio:\t%d\t\%5.2f", mamat, mapro);
    printf("\n\nAlumno con peor promedio:\t%d\t\%5.2f", memat, mepro);

    return 0;
}
