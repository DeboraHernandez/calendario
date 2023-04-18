// See https://aka.ms/new-console-template for more information
Console.WriteLine("TEMPERATURA");
double[,] temp;

temp = new double[7, 2];

//matriz
Console.WriteLine("D  -  N");
Random random = new Random();
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j< 2; j++)
    {
        temp[i, j] = random.Next(1,40);
    }
}
//imprimir matriz
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(temp[i, j]);
        if (j + 1 == 2)
        {
            Console.WriteLine();
        }
        else
        {
            Console.Write(" - ");
        }

    }
}
double prom = 0;
//sacar el promedio

    prom = (temp[4, 0] + temp[5,0] + temp[6,0])/3;
    Console.WriteLine("El promedio de los ultimos tres dias es " + prom);

// dia mas caluroso por la tarde
double datoMe = temp[0,0];

for (int i = 0; i < 7; i++)
{
    for (int j = 0;j < 2; j++)

        if (temp[i,0] < datoMe)
        {
            datoMe = temp[i,0];
            
        }
}
int cant = 0;
    Console.WriteLine("La temperatura menor por la mañana es " + datoMe);
double datoMa = temp[0, 0];
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 2; j++)

        if (temp[i, 1] > datoMa)
        {
            datoMa = temp[i, 1];

        }
}
Console.WriteLine("La temperatura mayor por la noche es " + datoMa);


for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 2; j++)
    {
        if (temp[i, j] < 30)
        {
            cant = cant + 1;
        }
    }
}
Console.WriteLine("La cantidad de dias con una temperatura menor a 30 es "+cant);
double prom2 = 0;

prom2 = (temp[0, 0] + temp[0, 1] + temp[1, 0] + temp[1, 1] + temp[2, 0] + temp[2, 1] + temp[3, 0] + temp[3, 1] + temp[4, 0] + temp[4,1] + temp[5,0] + temp[5,1] + temp[6,0] + temp[6,1]) / 14;
Console.WriteLine(prom2);