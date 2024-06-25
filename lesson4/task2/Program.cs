// ЗАДАЧА № 2

// Назовем число"интересным" если его сумма цифр четная

// Создать двумерный массив, состоящий из целых чисел.
// Вывести на экран"интересные" элементы массива.

// Шаги
// 1 создать массив и заполнить его случайными числами
// 2 Перебрать числа для проверк
// 3 Проверить массив на условие





int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// создаем строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // создаем столбцы
        {

            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine(); // Перенос на новую строку после вывод предыдущей
    }
}




int[,] matrix = CreateMatrix (3,4);// НАчало выполнения программы(Место входа)
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (isInteresting(e) is true)
    {
        Console.WriteLine(e);
    }

}

bool isInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits (int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}



