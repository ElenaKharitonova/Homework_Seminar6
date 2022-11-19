int PromptInt(string message) 
{
    Console.Write(message);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

int[] MyArray(int size)
{
    int [] result = new int [size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = PromptInt($"Введите элемент массива под индексом {i}: ");
    }
    return result; 
}

void PrintArray(int[] array)//печать одномерного массива
{
    System.Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine();
}

int NumberPositiveDigits (int[] array)
{
    int countPositive = 0;
    for (int i = 0; i < array.Length; i++)
        { 
            if (array[i]>0)    countPositive = countPositive + 1; 
     
    
        }
    return countPositive;
}

int m = PromptInt("Введите кол-во чисел, которое планируете сейчас ввести:  ");
int[] array = MyArray(m);
PrintArray(array);
Console.WriteLine("Количество введенных чисел больше нуля равно " + NumberPositiveDigits(array));

