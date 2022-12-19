/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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


double[] InitArray(int dimension)
{
    double[] array = new double[dimension];

    Random random = new Random();
    for (int i = 0; i < dimension; i++)
    {
        //array [i] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.WriteLine("Введите число");
        array[i] = double.Parse(Console.ReadLine() ??""); //ручной ввод элементов массива
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double GetDiff (double [] array)
{
    double max = array[0];
    double min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        {   
        max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double difference = max - min;
    return difference;
    
}

int dimension = GetNumber("Введите размерность массива");
double[] array = InitArray(dimension);
PrintArray(array);
double difference = GetDiff(array);

Console.WriteLine($"Разница между макс и мин: {difference}");