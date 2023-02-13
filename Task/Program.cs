// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнение алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] firstArray = new string[] {"yes", "345", "bike", "3", "copybook"};
string[] newArray = new string[firstArray.Length];

void Number(string[] firstArray, string[] newArray)
{
     int count = 0;
     for(int i= 0; i < firstArray.Length; i++)
     {
       if(firstArray[i].Length <= 3)
       {
          newArray[count] = firstArray[i];
          count++;
       }
     }
}

void Show(string[] array)
{
    for(int i= 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Number(firstArray, newArray);
Console.Write("Основной массив: ");
Show(firstArray);
Console.Write("Преобразованный массив: ");
Show(newArray);