// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек:");
double distance = 0;
double[]points = new double[6];
for(int i=0; i<points.Length; i++)
{
    points[i] = Convert.ToDouble(Console.ReadLine());
}
distance = Math.Sqrt((points[3]-points[0])*(points[3]-points[0])+(points[4]-points[1])*(points[4]-points[1])+(points[5]-points[2])*(points[5]-points[2]));
Console.WriteLine(distance);