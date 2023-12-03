//Высокий уровень, 8 (Назаров Руслан)

int[,] A = new int[3, 3];
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        A[i, j] = random.Next(1, 10);
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int minSum = int.MaxValue;
int minSumRow = -1;

for (int i = 0; i < 3; i++)
{
    int currentSum = 0;
    for (int j = 0; j < 3; j++)
    {
        currentSum += A[i, j];
    }

    if (currentSum < minSum)
    {
        minSum = currentSum;
        minSumRow = i;
    }
}
Console.WriteLine($"Строка с минимальной суммой элементов: {minSumRow + 1}");
Console.WriteLine();

int minSumResult = minSum * A[minSumRow, 0];
for (int j = 1; j < 3; j++)
{
    A[minSumRow, j] *= minSum;
    minSumResult *= A[minSumRow, j];
}
Console.WriteLine("Матрица после умножения:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Результат умножения всех элементов строки: {minSumResult}");