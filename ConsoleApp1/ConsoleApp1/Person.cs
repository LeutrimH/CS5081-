using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        static private int Count;
        private int Id;
        private string Name;
        private double Weight;
        private double Height;

        public Person(string name, double weight, double height)
        {
            Id = Count;
            Name = name;
            Weight = weight;
            Height = height;
            Count++;
        }

        public string ToString()
        {
            return "Id --> " + Id + " Name --> " + Name + " Weight --> " + Weight + " Height --> " + Height;
        }

        public double GetBmi()
        {
            return Weight / (Height * Height);
        }

        public int getId()
        {
            return Id;
        }
    }
}
