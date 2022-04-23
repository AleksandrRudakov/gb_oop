using System;

namespace less_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string s = Console.ReadLine();

            string _encode = "";

            Console.WriteLine("\nACoder:");

            ACoder ac = new ACoder(1);
            _encode = ac.Encode(s);
            Console.WriteLine($"encode: {_encode}");
            Console.WriteLine($"decode: {ac.Decode(_encode)}");

            Console.WriteLine("\nBCoder:");

            BCoder bc = new BCoder();
            _encode = bc.Encode(s);
            Console.WriteLine($"encode: {_encode}");
            Console.WriteLine($"decode: {bc.Decode(_encode)}");

            Console.ReadKey();
        }

        interface ICoder
        {
            string Encode(string s);
            string Decode(string s);
        }
        class ACoder : ICoder
        {
            private int _point;
            public int Point
            {
                get
                {
                    return _point;
                }
                set
                {
                    if (value > 65535)
                    {
                        _point = 65535;
                    }
                    else
                    {
                        _point = value;
                    }
                }
            }
            public ACoder(int point)
            {
                Point = point;
            }
            public string Encode(string s)
            {
                string result = "";
                for (int i = 0; i < s.Length; i++)
                {
                    result = result + (char)(((int)s[i] + Point) % 65535);
                }
                return result;
            }
            public string Decode(string s)
            {
                string result = "";
                for (int i = 0; i < s.Length; i++)
                {
                    result = result + (char)(((int)s[i] - Point) + ((((int)s[i] - Point) < 0) ? 65535 : 0));
                }
                return result;
            }
        }
        class BCoder : ICoder
        {
            public string Encode(string s)
            {
                string result = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if ((int)s[i] >= 65 && (int)s[i] <= 90)
                    {
                        result = result + (char)(90 - (int)s[i] + 65);
                    }
                    else if ((int)s[i] >= 97 && (int)s[i] <= 122)
                    {
                        result = result + (char)(122 - (int)s[i] + 97);
                    }
                    else if ((int)s[i] >= 1040 && (int)s[i] <= 1071)
                    {
                        result = result + (char)(1071 - (int)s[i] + 1040);
                    }
                    else if ((int)s[i] >= 1072 && (int)s[i] <= 1103)
                    {
                        result = result + (char)(1103 - (int)s[i] + 1072);
                    }
                    else
                    {
                        result = result + (char)((int)s[i]);
                    }
                }
                return result;
            }
            public string Decode(string s)
            {
                return Encode(s);
            }
        }
    }
}
