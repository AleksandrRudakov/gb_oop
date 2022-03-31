using System;

namespace less_4_library
{
    public class Building
    {
        static int LastNumber;
        private int number;
        private int height;
        private int floor;
        private int flat;
        private int entrance;
        public int Number { get { return this.number; } set { this.number = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }
        public int Floor { get { return this.floor; } set { this.floor = value; } }
        public int Flat { get { return this.flat; } set { this.flat = value; } }
        public int Entrance { get { return this.entrance; } set { this.entrance = value; } }
        public double FloorHeight()
        {
            return height / floor;
        }
        public int FlatInEntrance()
        {
            return flat / entrance;
        }
        public int FlatOnFloor()
        {
            return FlatInEntrance() / floor;
        }
        public int GenerateNumber()
        {
            LastNumber++;
            //return LastNumber.ToString().PadLeft(5, '0');
            return LastNumber;
        }
        public Building()
        {
            this.number = GenerateNumber();
            this.height = 1;
            this.floor = 1;
            this.flat = 1;
            this.entrance = 1;
        }
        public Building(int height, int floor, int flat, int entrance)
        {
            this.number = GenerateNumber();
            this.height = height;
            this.floor = floor;
            this.flat = flat;
            this.entrance = entrance;
        }
    }
}
