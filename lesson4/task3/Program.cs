﻿// ЗАДАЧА № 3:
// Считать с консоли строку, состоящую из
// цифр и латинских букв.

// Сформировать новую строку, состоящую из 
// букв исходной строки.
// 123PaswOrd

// Решение:

// Этапы решения:
// 1 Ввод строки
// 2. Проход по элементам строки
// 3. Проверка эл-та: является ли он буквой?
// 4. Дописать подходящий эл-т к новой строке
// (используем оператор конкатинации)

string GetLettersFromString (string s)
{
    string letters = "";
    foreach(char e in s) //цикл перебора эл-в строки
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e; // Операция конкатинации
        }// Метод проверяет нах-ся ли эл-т в таблице аски и я вляется ли он буквенным.
    }
    return letters;
}

string str = Console.ReadLine();// Создали строковую переменную и поместили в нее значение считанное с консоли 
string result = GetLettersFromString(str);// Запустим созднанную ф-ю с параметром  str сохранив в строковую переменную result
Console.WriteLine(result);