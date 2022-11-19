//Напищите программу, которая найдет точку пересечения двух прямых,
//заданных уравнениями y= k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2. k2 задаются пользователем

double[,] InputCoefficient(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Введите коэффициэнты {i+1}-го линейного уравнения y=k*x+b ->");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("Введите коэффициэнт k:  ");
            else Console.Write("Введите коэффициэнт b:  ");
            array[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

double [] CrossPointX (double[,] coefficient)//метод поиска координаты точки пересечения
{
    double k1 = coefficient[0,0];
    double k2 = coefficient[1,0];
    double b1 = coefficient[0,1];
    double b2 = coefficient[1,1];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double [] coordinate = new double[2];
    coordinate[0] = x;
    coordinate[1] = y;
    return coordinate;
}

double[,] coefficientOfEquation =new double [2,2];
InputCoefficient (coefficientOfEquation);
double [] point  = CrossPointX(coefficientOfEquation);
Console.WriteLine($"Точка пересечения прямых с заданными коэффициентами ({point[0]};{point[1]})");