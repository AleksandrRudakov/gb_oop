using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_6
{
    enum Color
    {
        Green,
        White,
        Blue,
        Red,
        Yellow
    }
    enum Condition
    {
        Visible,
        Invisible
    }
    class Figure
    {
        private Color _color;
        private Condition _condition;
        private int _x;
        private int _y;
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public Condition Condition
        {
            get
            {
                return _condition;
            }
            set
            {
                _condition = value;
            }
        }
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public Figure(Color color, Condition condition, int x, int y)
        {
            Color = color;
            Condition = condition;
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"{Color}, {Condition}, {X}, {Y}";
        }
        public Figure MoveX(int point)
        {
            X = X + point;
            return this;
        }
        public Figure MoveY(int point)
        {
            Y = Y + point;
            return this;
        }
        public Figure ChangeColor(Color color)
        {
            Color = color;
            return this;
        }
        public Condition GetCondition(Figure f)
        {
            return f.Condition;
        }
    }
    class Point : Figure
    {
        public Point(Color color, Condition condition, int x, int y) : base(color, condition, x, y)
        {
            Color = color;
            Condition = condition;
            X = x;
            Y = y;
        }
    }
    class Circle : Point
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public Circle(Color color, Condition condition, int x, int y, double radius) : base(color, condition, x, y)
        {
            Color = color;
            Condition = condition;
            X = x;
            Y = y;
            Radius = radius;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    class Rectangle : Point
    {
        private double _width;
        private double _length;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public Rectangle(Color color, Condition condition, int x, int y, double width, double length) : base(color, condition, x, y)
        {
            Color = color;
            Condition = condition;
            X = x;
            Y = y;
            Width = width;
            Length = length;
        }
        public double Area()
        {
            return Width * Length;
        }
    }
}
