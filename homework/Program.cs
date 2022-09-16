﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array = { "Этот", "массив", "введён", "заранее", "так как", "лень", "писать", "функцию", "для", "заполнения", "массива", "пользователем",
                    "Это", "конечно", "показывает", "меня", "не", "с лучшей", "стороны,", "но", "я", "рискну", "оставить", "как", "есть" }; // массив строк для задания
void WriteArray(string[] array) // функция вывода массива в консоль
{
    Console.Write($"{"["}");
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        Console.Write($"\"{array[i]}\"{", "}");
    }
    Console.Write($"\"{array[array.Length - 1]}\"{".]  "}");
}