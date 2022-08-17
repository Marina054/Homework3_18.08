// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

internal class NewBaseType
{
    public static void Main (string[] args)
    
        {
            Console.Write("Введите 1 координату А:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 2 координату A:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 3 координату A:");
            double z1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 1 координату B:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 2 координату B:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 3 координату B:");
            double z2 = Convert.ToDouble(Console.ReadLine());
            
            double distanse= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine ($"Растояние равно: {distanse}");
    
            Console.WriteLine ($"Растояние равно: {distanse}");
            Console.WriteLine("Введите следующие координаты");

            Console.Write("Введите 1 координату А:");
            double xx1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 2 координату A:");
            double yy1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 3 координату A:");
            double zz1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 1 координату B:");
            double xx2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 2 координату B:");
            double yy2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 3 координату B:");
            double zz2 = Convert.ToDouble(Console.ReadLine());
            
            double distanse2= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine ($"Растояние равно: {distanse2}");
    
            Console.WriteLine ($"Растояние равно: {distanse}");
            Console.WriteLine("Спасибо!)");
        }  
        
        
            
}       