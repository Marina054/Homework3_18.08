// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

class Program
{
    public static void Main (string[]args)
     
    {
    Console.Write("Добрый день, введите, пожалуйста Ваше число: ");

    int number = Convert.ToInt32(Console.ReadLine());  

    if (number >1) Console.WriteLine ("");
         
    Console.WriteLine($"Ваше число {number}");
             
             for(int i=0;i<number; i++)
             { 
                Console.Write(Math.Pow(i+1, 3) + ";");
             }

    }

}

    
                
        
