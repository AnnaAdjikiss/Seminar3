// Программа принимает на вход координаты точки (причем х и у не равны нулю),
// Выдает на выходе номер четверти плоскости, в которой находится точка.
int GetQuart(double xPoint, double yPoint)
{
    if (xPoint > 0 && yPoint > 0) return 1;
    if (xPoint < 0 && yPoint > 0) return 2;
    if (xPoint < 0 && yPoint < 0) return 3;
    if (xPoint > 0 && yPoint < 0) return 4;
    return 0;                               
}
double x,y;
int quartNum;
Console.Write ("Input x:  ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input y: ");
y = Convert.ToDouble(Console.ReadLine());
quartNum = GetQuart(x, y);
if (quartNum == 0) Console.WriteLine("It's impossible to determine quarter");
else Console.WriteLine("The point is in " + quartNum + " quarter");
