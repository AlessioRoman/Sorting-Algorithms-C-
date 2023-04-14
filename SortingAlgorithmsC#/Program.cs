Random random = new Random();

Console.WriteLine("Digita il numero di elementi da inserire nell'array: ");
int numbersOfElements = int.Parse(Console.ReadLine());
Console.WriteLine("Digita il minimo dell'array: ");
int minArray = int.Parse(Console.ReadLine());
Console.WriteLine("Digita il massimo dell'array: ");
int maxArray = int.Parse(Console.ReadLine());

int[] randomizedArray = randomArrayInt(numbersOfElements, minArray, maxArray);

Console.WriteLine("Array generato randomicamente: ");
printArrayInt(randomizedArray);
Console.WriteLine();
Console.WriteLine("Array ordinato: ");
printArrayInt(selectionSort(randomizedArray));


int[] selectionSort(int[] array)
{
    int minIndex;
    for (int i = 0; i < array.Length; i++)
    {
        //Trovo il minimo
        minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }
        //Scambio di posizione
        int tmp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = tmp;
    }
    return array;
}

int[] randomArrayInt(int arraySize, int min, int max)
{
    //Inizializzo l'array da generare
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        //Estraggo randomicamente dei numeri nel range min, max e li assegno alla posizione i nell'array
        array[i] = random.Next(min, max);
    }
    return array;
}
void printArrayInt(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.Write("]");
}
