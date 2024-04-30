// # Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Исходный массив можно ввести вручную,
// либо задать на начальном этапе выполнения алгоритма. При решении задачи не рекомендуется
// использовать коллекции, лучше работать только с массивами.
// # Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// Шаг 1: Запрос размера массива строк у пользователя
Console.Write("Введите количество строк в массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

// Шаг 2: Ввод данных пользователем и сохранение в массиве
string[] inputStrings = new string[arraySize];
for (int i = 0; i < arraySize; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    inputStrings[i] = Console.ReadLine();
}

// Шаг 3: Подсчет подходящих строк (длина не более 3 символов)
int suitableCount = 0;
foreach (string str in inputStrings)
{
    if (str.Length <= 3)
        suitableCount++;
}

// Шаг 4: Создание нового массива с подходящими строками
string[] suitableStrings = new string[suitableCount];
int index = 0;
foreach (string str in inputStrings)
{
    if (str.Length <= 3)
    {
        suitableStrings[index] = str;
        index++;
    }
}

// Шаг 5: Вывод результатов
Console.WriteLine("\nИсходный массив строк:");
foreach (string str in inputStrings)
{
    Console.WriteLine(str);
}

Console.WriteLine("\nНовый массив с подходящими строками (длина <= 3 символов):");
foreach (string str in suitableStrings)
{
    Console.WriteLine(str);
}

