using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemokproject.Models
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }

        [NonSerialized]
        public int TempID;

        public int Age { get; set; }

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            TempID = new Random().Next(1000, 9999);
        }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
