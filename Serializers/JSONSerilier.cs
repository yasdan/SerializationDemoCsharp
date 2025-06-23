using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SerializationDemokproject.Models;

namespace SerializationDemokproject.Serializers
{
    public class JSONSerilier
    {
        public static void Run(string name, int age)
        {
            try
            {
                Person person = new Person(name, age);
                string path = "person.json";

                string json = JsonSerializer.Serialize(person);
                File.WriteAllText(path, json);

                string readJson = File.ReadAllText(path);
                Person deserialized = JsonSerializer.Deserialize<Person>(readJson);

                Console.WriteLine("Deserialized from JSON: " + deserialized);
            }
            catch (Exception ex)
            {
                SerializationExceptinHndler.Handle(ex);
            }
        }

    }
}
