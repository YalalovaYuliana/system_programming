using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperationLecture
{
    internal abstract class Figure
    {
        public abstract void Draw();
    }
    abstract class Quadrangle : Figure { }

    class Square : Quadrangle
    {
        public int Length { get; set; }
        public static explicit operator Square(Rectangle rect)
        {
            return new Square { Length = rect.Height };
        }
        public static explicit operator int(Square s) => s.Length;
        public static implicit operator Square(int number) => new Square { Length = number };
        public override void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("* ");
                }
            }
        }
        public override string ToString()
        {
            return $"Square: Length = {Length}";
        }
    }

    class Rectangle : Quadrangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle { Height = s.Length, Width = s.Length * 2 };
        }
        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }
            }
        }
        public override string ToString()
        {
            return $"Rectangle: Width = {Width}, Height = {Height}";
        }
    }
}
