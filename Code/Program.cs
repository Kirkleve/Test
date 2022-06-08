/*
Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться, коллекциями, лучше обойтись исключительно массивами.

["hello","2","world",":-)"] -> ["2",":-)"]
["1234","1567","-2","computer science"] -> ["-2"]
["Russia","Denmark","Kazan"] -> []
*/
string PrintArray(string[] array)
{
    string restore = String.Empty;
    int size = array.Length;
    restore = "[";
    for (int i = 0; i < size; i++)
    {
        restore += $" {array[i]}";
    }
    restore += "]";
    return restore;
}

string[] array = new string[] {"hello","2","world",":-)"};
Console.WriteLine(PrintArray(array));


for (int i =0; i< array.Length;i++)
{
    int rand = new Random().Next(array[i],array[i+1]);
    if (array[i] == array[rand])
    {

    }
}


