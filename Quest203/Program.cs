
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double length(double x1, double y1, double x2, double y2)
{
    // x1 = 1, y1 = 1
    // x2 = 3, y2 = 5
    double deltaX = Math.Abs(x1 - x2);
    double deltaY = Math.Abs(y1 - y2);
    double deltaXY = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
    return deltaXY;
}

double ax = 3;
double ay = 2;
double bx = 6;
double by = 1;

Console.WriteLine("lenght " + Math.Round(length(ax, ay, bx, by),2));

*/


