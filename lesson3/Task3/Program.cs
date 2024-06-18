// ЗАДАНИЕ №3

// Создать функцию которая будет изменять элементы массива.

// создадим ф-ю которая обнулит четные эл-ты массива:

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 8, 3, 6, 4, 1 };
ZeroEvenElements(array);
PrintArray(array);