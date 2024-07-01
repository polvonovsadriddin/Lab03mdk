using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab3mdk
{


    public class Cursor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Orientation { get; set; }
        public int Size { get; set; }
        public string Visible { get; set; }

        public Cursor(int x = 0, int y = 0, string orientation = "horizontal", int size = 1)
        {
            X = x;
            Y = y;
            Orientation = orientation;
            Size = size;
            Visible = "Отсутствует";
        }

        public static Cursor operator +(Cursor cursor, (int x, int y) coordinates)
        {
            cursor.X += coordinates.x;
            cursor.Y += coordinates.y;
            return cursor;
        }

        public static Cursor operator -(Cursor cursor, (int x, int y) coordinates)
        {
            cursor.X -= coordinates.x;
            cursor.Y -= coordinates.y;
            return cursor;
        }

        public static implicit operator Cursor(string orientation)
        {
            return new Cursor() { Orientation = orientation };
        }

        public static implicit operator Cursor(int size)
        {
            return new Cursor() { Size = size };
        }

        public void HideCursor()
        {
            Visible = "Не виден";
        }

        public void ShowCursor()
        {
            Visible =  "Виден";
        }
    }
}