/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message);
{
    int result = 0;
    string errorMessage = "Вы ввели не число.Введите корректное число.";

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result));
        break;
    }
    else
    {
        {Console.Clear();
        Console.WriteLine(errorMessage);    
        }
    }
    return result
}


int x1 = GetNumber("Введите координату x 1 точки");
int y1 = GetNumber("Введите координату y 1 точки");
int z1 = GetNumber("Введите координату z 1 точки");
int x2 = GetNumber("Введите координату x 2 точки");
int y2 = GetNumber("Введите координату y 2 точки");
int z2 = GetNumber("Введите координату z 2 точки");

length = Math.Cbrt(Math.Pow(x3-x2-x1, 3) + Math.Pow(y3-y2-y1, 3) + Math.Pow(z3-z2-z1, 3));
Console.WriteLine($"Расстояние между точками равняется {length});