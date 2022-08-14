// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");

int xx1 = Coordinate("x", "A");
int yy1 = Coordinate("y", "A");
int zz1 = Coordinate("z", "A");
int xx2 = Coordinate("x", "B");
int yy2 = Coordinate("y", "B");
int zz2 = Coordinate("z", "B");

int Coordinate2(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision2(double xx1, double xx2, 
                double yy1, double yy2, 
                double zz1, double zz2){
  return Math.Sqrt(Math.Pow((xx2-xx1), 2) + 
                   Math.Pow((yy2-yy1), 2) + 
                   Math.Pow((zz2-zz1), 2));
}

double segmentLength2 =  Math.Round (Decision(xx1, xx2, yy1, yy2, zz1, zz2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength2}");

