//Задача: из имеющего массива строк сформировать массив из строк длина которых <= 3 символам
//Массив с данными заполняет программа

string[] inputArray = new string[] { "hello", "2", "world", ":-)" };
PrintArray(GetArrayLessThreeChar(inputArray));

//Метод получения массива состоящего из строк с длиной <= 3
string[] GetArrayLessThreeChar(string[] array)
{
    int lenghtNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= 3)
            {
                lenghtNewArray++;
            }
        }
    }

    string[] newArray = new string[lenghtNewArray];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

//Печать массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}