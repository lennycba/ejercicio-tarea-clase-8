Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("--------------------------------------------------------------------------------------------------");
Console.WriteLine("* Buenos días... a continuación se le pedirá ingresar el numero de filas y columnas de la matriz *");
Console.WriteLine("--------------------------------------------------------------------------------------------------");
//-------------------------------------------------------------------------------------------
// Recibo por consola los valores que voy a utilizar para el programa
//-------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("ingrese por favor el número de filas");
int filas = int.Parse(Console.ReadLine());
    Console.WriteLine();
Console.WriteLine("ahora, ingrese por favor el número de columnas");
int columnas = int.Parse(Console.ReadLine());
Console.Clear();
//-------------------------------------------------------------------------------------------
// Defino la matriz y los arrays que voy a utilizar
//-------------------------------------------------------------------------------------------

int[,] numeros = new int[filas, columnas];
double[] promedios = new double[columnas];
int[] sumatoria = new int[columnas];

//-------------------------------------------------------------------------------------------
// Obtengo la cantidad de filas y columnas para usarlas en lof "for" anidados
//-------------------------------------------------------------------------------------------

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumas = numeros.GetUpperBound(1) + 1;

//-------------------------------------------------------------------------------------------
// Recorro la matriz recibiendo y cargando los valores en su respectiva posición
//-------------------------------------------------------------------------------------------
Console.Clear();
for (int i = 0; i < lengthFilas; i++)
{
    for(int j = 0; j < lengthColumas; j++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("ingrese por favor el valor para la fila Nº " + (i + 1) +" y la "+ "columna Nº "+ (j+1));
        Console.WriteLine("---------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        numeros[i, j] = int.Parse(Console.ReadLine());
        sumatoria[j]+= numeros[i, j];
        Console.Clear();
    }
}

//-------------------------------------------------------------------------------------------
// Recorro la matriz mostrando de manera ordenada los valores de las distintas posiciones
//-------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("---------------------------------");
Console.WriteLine("|Los valores ingresados fueron: |");
Console.WriteLine("---------------------------------");
Console.WriteLine();

for (int i = 0; i < lengthFilas; i++)
{
    for (int j = 0; j < lengthColumas; j++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write (" "+numeros[i,j]+" ");
    }

 Console.WriteLine();
 Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("------------------------------------");
Console.WriteLine("* Y el promedio de cada columna es *");
Console.WriteLine("------------------------------------");
//-----------------------------------------------------------------------------------------------------
// Recorro el array "sumatoria" dividiendo cada valor por el numero de filas ingresadas por el usuario
//-----------------------------------------------------------------------------------------------------

for (int k = 0; k < sumatoria.Length; k++)
{
    promedios[k] = (sumatoria[k] / filas);

//----------------------------------------------------------------------------------------------------
// Recorro el vector "promedios" imprimiendo en consola los valores alineados a su respectiva columna
//----------------------------------------------------------------------------------------------------
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(" "+promedios[k]+" ");
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("------------------------------------");
Console.WriteLine();
Console.WriteLine();
Console.ResetColor();