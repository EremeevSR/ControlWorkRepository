// Формирование массива, передаваемого на вход метода,
// возвращающего массив строк требуемой длины.
string sentense = "This is the first sentence in a string.";
char[] separators = new char[] { ' ', '.' };
string[] arrOfStr = sentense.Split(separators, StringSplitOptions.RemoveEmptyEntries);

// Код основной программы для проверки работы алгоритма,
// реализованного в качестве отдельного метода.
int maxLength = 3;
Console.WriteLine("Исходный массив: ");
PrintArray(arrOfStr);
string[] algorithmResult = GetStringArr(in arrOfStr, in maxLength);
Console.WriteLine("Обработанный массив: ");
PrintArray(algorithmResult);

// Методы ---------------------------------------------------------------------- 

string[] GetStringArr(in string[] initialArrOfStr, in int maxLength)
{
    // Метод возвращает массив строк, являющийся результатом выборки из
    // исходного массива initialArrOfStr тех строк, длина которых меньше
    // либо равна maxLengthOfStrings.

    int inLength = initialArrOfStr.Length;
    string[] tempArr = new string[inLength];
    int outArrLength = 0;

    for (int i = 0; i < inLength; i++)
    {
        if (initialArrOfStr[i].Length <= maxLength)
            tempArr[outArrLength++] = initialArrOfStr[i];
    }

    Array.Resize(ref tempArr, outArrLength);

    return tempArr;
}

void PrintArray(string[] arr)
{
    // Построчный вывод элементов массива arr.
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine(arr[i]);
}