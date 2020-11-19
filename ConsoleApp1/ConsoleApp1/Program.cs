using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static private List<Person> People = new List<Person>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 add person \n2 remove person \n3 list person \n4 get BMI for person");
                string input = Console.ReadLine();

                int option = Int32.Parse(input);
                switch(option)
                {
                    case 1:
                        Console.WriteLine("----- 1 add person");
                        Console.WriteLine(AddPerson());
                        break;
                    case 2:
                        Console.WriteLine("----- 2 remove person");
                        Console.WriteLine(RemovePerson());
                        break;
                    case 3:
                        Console.WriteLine("----- 3 list People");
                        Console.WriteLine(ListPeople());
                        break;
                    case 4:
                        Console.WriteLine("----- 4 get BMI for person");
                        Console.WriteLine(GetBMIForPerson());
                        break;
                    default:
                        break;
                }
            }
        }

        static public string AddPerson()
        {
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("height");
            double height = Convert.ToDouble(Console.ReadLine());

            Person newPerson = new Person(name, weight, height);
            People.Add(newPerson);

            return newPerson.ToString();
        }

        static public string RemovePerson()
        {
            Console.WriteLine("pick id");
            ListPeople();
            int id = Int32.Parse(Console.ReadLine());
            foreach (var person in People)
            {
                if (person.getId() == id)
                {
                    People.Remove(person);
                    return person.ToString();
                }
            }
            return "Id Not Found";
        }

        static public string ListPeople()
        {
            string Outputter = "";
            foreach (var person in People)
            {
                Outputter += person.ToString();
            }
            return Outputter;
        }

        static public string GetBMIForPerson()
        {
            Console.WriteLine("pick id");
            ListPeople();
            int id = Int32.Parse(Console.ReadLine());
            foreach (var person in People)
            {
                if (person.getId() == id)
                {
                    return "" + person.GetBmi();
                }
            }
            return "Id Not Found";
        }
    }
}