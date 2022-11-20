//Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
//Затем найдите минимальное значение по каждой колонке, получите сумму этих минимов. 
//Затем из первой суммы (с максимумами) вычтите вторую сумму (с минимумами).

int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arrNums)
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        System.Console.Write($"{arrNums[i, 0]}");
        for (int j = 1; j < arrNums.GetLength(1); j++)
        {
            System.Console.Write($" {arrNums[i, j]}");
        }
        System.Console.WriteLine("");
    }
}

int SumMaxArray(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        int tempMaxColumn = array[j, 0];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            if (tempMaxColumn < array[j, i])
            {
                tempMaxColumn = array[j, i];
            }
        }
        sum = sum + tempMaxColumn;
    }
    return sum;
}

int SumMinArray(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int tempMinString = array[0, j];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (tempMinString > array[i, j])
            {
                tempMinString = array[i, j];
            }
        }
        sum = sum + tempMinString;
    }
    return sum;
}

int DifferenceMaxMin(int min, int max)
{
    int difference = max - min;
    return difference;
}

System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Введите m (кол-во строк): ");
int n = PromptInt("Введите n (кол-во столбцов): ");
int[,] matrix = FillArray(m, n);
PrintArray(matrix);
int maxValue = SumMaxArray(matrix);
int minValue = SumMinArray(matrix);
int result = DifferenceMaxMin(minValue, maxValue);
System.Console.Write($"Разница между суммой максимальных значений по строкам массива {maxValue} ");
System.Console.Write($"и суммой минимальных значений по столбцам массива {minValue} ");
System.Console.Write($"равна: {result}");