using System;
using System.ComponentModel.Design;

class Program
{
    static int LinearSearch(int[] array, int target)
    {
        int[] tmparr = new int[array.Length+1];
        tmparr=array;
        tmparr[tmparr.Length-1]=target;
        for (int i = 0; i < array.Length; i++)
        {
            if (tmparr[i] == tmparr[tmparr.Length - 1])
            {
                return i;
            }else if (i == (tmparr.Length - 1))
            {
                return -1;
            }
        }
        return 1;
    }

   

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 1000);
        }
        return array;
    }

    static void Main(string[] args)
    {
        int[] randomArray = GenerateRandomArray(100);
        Console.WriteLine(string.Join(" ", randomArray));

        Console.WriteLine("Podaj wartość do znalezienia:");
        int target = Convert.ToInt32(Console.ReadLine());

        int index = LinearSearch(randomArray, target);
        if (index != -1)
        {
            Console.WriteLine($"Dodano {target} znajduje się na pozycji {index}.");
        }
        else if (index != 1)
        {
            Console.WriteLine($"Dodano {target} znajduje się na pozycji {index}.");

        }
        else { 
           Console.WriteLine("cos nie tak");
        }
    }
}
