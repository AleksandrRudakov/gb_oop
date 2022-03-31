using System;
using System.Collections;
using System.Collections.Generic;
using less_4_library;

namespace less_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creator creator = new Creator();
            Creator.CreateBuild(100, 4, 50, 1);
            Creator.CreateBuild(100, 5, 50, 1);
            Creator.CreateBuild(100, 8, 50, 1);

            Creator.DeleteBuild(3);

            foreach (DictionaryEntry de in Creator.Hashtable)
            {
                Building b = (Building)de.Value;
                Console.WriteLine($"number = {b.Number}; height = {b.Height}; floor = {b.Floor}; flat = {b.Flat}; entrance = {b.Entrance}; " +
                    $"FloorHeight = {b.FloorHeight()}; FlatInEntrance = {b.FlatInEntrance()}; FlatOnFloor = {b.FlatOnFloor()}");
            }

            Console.ReadKey();
        }
    }
}
