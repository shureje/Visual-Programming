using System;
using System.Runtime.CompilerServices;

namespace MyApp
{
    class Coord
    {
        private double x, y, z;

        public double X => x;
        public double Y => y;
        public double Z => z;

        public Coord() { }
        public Coord(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

        public double GetCoords(char coord)
        {
            return coord switch
            {
                'x' or 'X' => this.x,
                'y' or 'Y' => this.y,
                'z' or 'Z' => this.z,
                _ => throw new ArgumentException("Invalid axis. Must be 'x', 'y' or 'z'.")
            };
        }
    }
    class Vector3d
    {
        private Coord coords;
        private Coord startCoord;


        public Vector3d()
        {
            this.coords = new Coord(0, 0, 0);
            this.startCoord = new Coord(0, 0, 0);
        }
        public Vector3d(double x, double y, double z)
        {
            this.coords = new Coord(x, y, z);
            this.startCoord = new Coord(0,0,0);
        }
        public Vector3d(double x, double y, double z, double startx, double starty, double startz)
        {
            this.coords = new Coord(x, y, z);
           this.startCoord = new Coord(startx, starty, startz);
        }

        public override string ToString()
        {
            return $"(Coordinates: {coords.X}, {coords.Y}, {coords.Z}), startPosition: {startCoord.X}, {startCoord.Y}, {startCoord.Z}";
        }

        //getters
        public Double GetProjection(char axis)
        {
            return axis switch
            {
                'x' or 'X' => this.coords.X - this.startCoord.X,
                'y' or 'Y' =>  this.coords.Y - this.startCoord.Y,
                'z' or 'Z' =>  this.coords.Z - this.startCoord.Z,
                _ => throw new ArgumentException("Invalid axis. Must be 'x', 'y' or 'z'.")
            };
        }
        //methods
        public static Vector3d Add(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.GetProjection('x') + v2.GetProjection('x'),
                                v1.GetProjection('y') + v2.GetProjection('y'),
                                v1.GetProjection('z') + v2.GetProjection('z'));
        }

        public static Vector3d Sub(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.GetProjection('x') - v2.GetProjection('x'),
                                v1.GetProjection('y') - v2.GetProjection('y'),
                                v1.GetProjection('z') - v2.GetProjection('z'));
        }

        public Vector3d Multiply(double k)
        {
            this.coords = new Coord(this.coords.X * k, this.coords.Y * k, this.coords.Z * k);
            return this;
        }

        public Double GetModule()
        {
            return Math.Sqrt(coords.X * coords.X
                            + coords.Y * coords.Y
                            + coords.Z * coords.Z);
        }
    }
}