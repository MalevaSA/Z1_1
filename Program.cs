using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
       public static void Main()
    {
Console.Write("Введите длину стороны квадрата ");
int a=int.Parse(Console.ReadLine()); // Длина
double S; // Площадь квадрата
double P; // Периметр квадрата
double L; // Длина вписанной окружности
double s; // Площадь вписанной окружности 
        S=a*a;
        P=4*a;
        L=3.14*a;
        s = a * a * 3.14 / 4;
        Console.WriteLine("Площадь квадрата равна {0:g5}", S);
        Console.WriteLine("Периметр квадрата равен {0:g5}", P);
        Console.WriteLine("Длина вписанной окружности равна {0:g5}", L);
        Console.WriteLine("Площадь вписанной окружности равна {0:g5}", s);
        Console.ReadKey();
    }
    }
}
