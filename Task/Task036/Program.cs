/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-99, 100);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

int GetSumNegative(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        summ = summ + arr[i];
    }
    return summ;
}

int dimension = GetNumber("Введите размерность");
int[] arr = InitArray(dimension);
PrintArray(arr);

int getSumNegative = GetSumNegative(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях = {getSumNegative}");

