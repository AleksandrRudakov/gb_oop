using System;

namespace less_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank account:");

            BankAccount ba1 = new BankAccount(1000, AccountType.CurrentAccount);
            Console.WriteLine("bank account 1: " + ba1.ToString());

            BankAccount ba2 = new BankAccount(1500, AccountType.CurrentAccount);
            Console.WriteLine("bank account 2: " + ba2.ToString());

            Console.WriteLine("\nResult:");

            Console.WriteLine("operator ==:          " + (ba1 == ba2));
            Console.WriteLine("operator !=:          " + (ba1 != ba2));
            Console.WriteLine("method Equals():      " + ba1.Equals(ba2));
            Console.WriteLine("method GetHashCode(): " + ba1.GetHashCode());

            Console.WriteLine("\nFigure:");
            
            Console.WriteLine("\nPoint:");

            Point p = new Point(Color.Green, Condition.Visible, 10, 50);
            Console.WriteLine($"Initial values:     {p.ToString()}");
            p.MoveX(5);
            Console.WriteLine($"MoveX(5):           {p.ToString()}");
            p.MoveY(-10);
            Console.WriteLine($"MoveY(-10):         {p.ToString()}");
            p.ChangeColor(Color.White);
            Console.WriteLine($"ChangeColor(White): {p.ToString()}");

            Console.WriteLine("\nCircle:");

            Circle c = new Circle(Color.Green, Condition.Visible, 10, 50, 10);
            Console.WriteLine($"Initial values:     {c.ToString()}");
            c.MoveX(5);
            Console.WriteLine($"MoveX(5):           {c.ToString()}");
            c.MoveY(-10);
            Console.WriteLine($"MoveY(-10):         {c.ToString()}");
            c.ChangeColor(Color.White);
            Console.WriteLine($"ChangeColor(White): {c.ToString()}");
            Console.WriteLine($"Radius(10):         {c.Area()}");

            Console.WriteLine("\nRectangle:");

            Rectangle r = new Rectangle(Color.Green, Condition.Visible, 10, 50, 10, 50);
            Console.WriteLine($"Initial values:     {r.ToString()}");
            r.MoveX(5);
            Console.WriteLine($"MoveX(5):           {r.ToString()}");
            r.MoveY(-10);
            Console.WriteLine($"MoveY(-10):         {r.ToString()}");
            r.ChangeColor(Color.White);
            Console.WriteLine($"ChangeColor(White): {r.ToString()}");
            Console.WriteLine($"Radius(10,50):      {r.Area()}");

            Console.ReadKey();
        }
    }
}
