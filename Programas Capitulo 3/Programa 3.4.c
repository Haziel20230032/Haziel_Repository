#include <stdio.h>
#include <stdlib.h>

int main()
{
   int num;
    long cua, sum = 0;

    printf("\nIngrese un n�mero entero -0 para terminar-: ");
    scanf("%d", &num);

    while (num)
    {
        cua = pow(num, 2);
        printf("%d al cubo es %ld\n", num, cua);
        sum += cua;
        printf("\nIngrese un n�mero entero -0 para terminar-: ");
        scanf("%d", &num);
    }

    printf("\nLa suma de los cuadrados es %ld\n", sum);

    return 0;

}
