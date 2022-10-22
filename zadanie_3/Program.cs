Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();    
}

Console.WriteLine();
Console.WriteLine("В ячейках, имеющих оба четных индекса, возводим числа в квадрат");
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        if(i%2==0 && j%2==0) matrix[i, j] = matrix[i, j] * matrix[i, j];
        else matrix[i, j] = matrix[i, j];
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();    
}