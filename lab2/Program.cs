using System;
using System.Numerics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program start");

            Vector3d vector1 = new Vector3d(1, 2, 3, 2, 4, 0);
            Vector3d vector2 = new Vector3d(3, 2, 1);

            Console.WriteLine("Add:");
            Vector3d vector3 = Vector3d.Add(vector1, vector2);
            Console.WriteLine("Vector1: " + vector1);
            Console.WriteLine("Vector2: " + vector2);
            Console.WriteLine("Vector3: " + vector3);
            Console.WriteLine();


            Console.WriteLine("Substract:");
            vector3 = Vector3d.Sub(vector1, vector2);
            Console.WriteLine("Vector1: " + vector1);
            Console.WriteLine("Vector2: " + vector2);
            Console.WriteLine("Vector3: " + vector3);
            Console.WriteLine();

            Console.WriteLine($"Projection:");
            Coord coord = new Coord(vector1.GetProjection('x'),
                                    vector1.GetProjection('y'),
                                    vector1.GetProjection('z'));

            Console.WriteLine(coord);
            Console.WriteLine();


            Console.WriteLine($"Module:");
            Console.WriteLine(vector1.GetModule());
            Console.WriteLine();


        }
    }
}