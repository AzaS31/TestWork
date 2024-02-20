using System;

class Program 
{
    static void Main()
    {
        string[] array = { "Урок", "Задание", "Два", "Пять", "Оценка", "Три" };
        Console.Write($"[{String.Join(", ", array)}] => ");
        int count = 0;
       
        foreach (string word in array)
        {
            if (word.Length <= 3)
            {
                count++;
            }
        }

        string[] res = new string[count];
        int index = 0;
        
        foreach (string word in array)
        {
            if (word.Length <= 3)
            {
                res[index] = word;
                index++;
            }
        }
        Console.Write($"[{String.Join(", ", res)}]");
    }
}
