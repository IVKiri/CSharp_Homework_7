// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите размер массива m x n. ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [m, n];
for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = Math.Round(new Random().Next( 0, 10) + new Random().NextDouble(), 2);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
