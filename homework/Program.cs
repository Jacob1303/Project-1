// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
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

string[] FormationNewArray(string[] array) // функция для редактирования массива согласно условиям
{
    for (int i = 0; i <= array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length > 3)
            {
                array = array.Except(new string[] { array[j] }).ToArray();
            }
        }
    }
    return array;
}

int CheckArray(string[] arr) // функция проверки наличия строк в массиве, удовлетворяющих услувиям
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count = 1;
    }
    return count;
}