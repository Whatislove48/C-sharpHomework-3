
/*
Напишите программу, которая принимает
 на вход координаты двух точек 
 и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


double length(double x1, double y1,double z1, double x2, double y2, double z2)
{
    double deltaX = Math.Abs(x1 - x2);
    double deltaY = Math.Abs(y1 - y2);
    double deltaZ = Math.Abs(z1 - z2);
    double deltaXYZ = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY)+(deltaZ*deltaZ));
    return deltaXYZ;
}

double ax = 7, ay = -5, az = 0;
double bx = 1, by = -1, bz = 9;

Console.WriteLine("lenght = " + Math.Round(length(ax, ay, az, bx, by, bz),2));

