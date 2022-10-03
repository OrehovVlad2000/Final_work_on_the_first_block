// Задача: Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int NumberOfLinesWithLength3(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int temp = array[i].Length;
        if (temp <= 3)
        {
            count ++;
        }
    }
    return count;
}

string[] SelectStrings3CharactersLong(string[] array, int size)
{
    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int temp = array[i].Length;
        if (temp <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

string[] myArray = {"Hello", "2", "world", ":-)", "The", "12345", "ijk"};
int mySize = NumberOfLinesWithLength3(myArray);
Console.WriteLine(String.Join(", ", SelectStrings3CharactersLong(myArray, mySize)));