// ЛЕКЦИЯ 4 Двумерные Массивы:

// Задача №1
// Создать двумерный массив с резмерами 3 х 5, 
// состоящий из целых чисел.
// Вывести на экран.
// int[,] matrix = new int[3, 5];


// Цикл:

// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)// создаем строки
// {
//      for (int j = 0; j < matrix.GetLength(1); j++) // создаем столбцы
//      {

//         matrix[i, j] = rnd.Next(1, 11);
//      }
//  }





// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {

//         Console.Write($"{matrix [i,j]} ");
//     }
//     Console.WriteLine(); // Перенос на новую строку после вывод предыдущей
// }


// ФУНКЦИЯ:


int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// создаем строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // создаем столбцы
        {

            matrix[i, j] = rnd.Next(1, 11);
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


int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);// создали пер-ю matrix для хранения массива и вызвали ф-ю CreateMatrix