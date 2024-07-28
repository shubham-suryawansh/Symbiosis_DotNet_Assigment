using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbAss2
{
    class Person : IComparable<Person>
    {
        // Member variables
        public string Name { get; set; }
        public int Age { get; set; }

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to print Person's details
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Implementing the CompareTo method of IComparable interface
        public int CompareTo(Person other)
        {
            if (other == null) return 0 ;
            if (this.Age > other.Age) return 1;
            if (this.Age < other.Age) return -1;
            else return 0;
        }

        public static void Main(string[] args)
        {
            // Create an array of 3 Persons
            Person[] people = new Person[3];
            people[0] = new Person("Shivani", 20);
            people[1] = new Person("Sayali", 35);
            people[2] = new Person("Komal", 10);

            // Print details before sorting
            Console.WriteLine("Before sorting:");
            foreach (var person in people)
            {
                person.PrintDetails();
            }

            // Sort the array of Persons
            Array.Sort(people);

            // Print details after sorting
            Console.WriteLine("\nAfter sorting:");
            foreach (var person in people)
            {
                person.PrintDetails();
            }
            Console.ReadKey();
        }
    }
}
