// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int Coordinates(string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Clear();
// Console.WriteLine("Введите кординату точки A");
// int coordX1 = Coordinates("Введите X: ");
// int coordY1 = Coordinates("Введите Y: ");
// int coordZ1 = Coordinates("Введите Z: ");
// Console.WriteLine("Введите кординату точки B");
// int coordX2 = Coordinates("Введите X: ");
// int coordY2 = Coordinates("Введите Y: ");
// int coordZ2 = Coordinates("Введите Z: ");

// double distace = Math.Sqrt(Math.Pow(coordX1 - coordX2, 2) + Math.Pow(coordY1 - coordY2, 2) + Math.Pow(coordZ1 - coordZ2, 2));

// Console.WriteLine("Расстояние между точкой А и B = " + distace);

void PrintDistance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine("Растояние между точками" + distance);
}


int x1 =  Coordinates("Введите X1 = ");
int y1 =  Coordinates("Введите Y1 = ");
int z1 =  Coordinates("Введите Z1 = ");
int x2 =  Coordinates("Введите X2 = ");
int y2 =  Coordinates("Введите Y2 = ");
int z2 =  Coordinates("Введите Z2 = ");



PrintDistance(x1, x2, y1, y2, z1, z2);
