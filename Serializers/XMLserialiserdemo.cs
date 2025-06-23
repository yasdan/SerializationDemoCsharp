using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SerializationDemokproject.Models;

namespace SerializationDemokproject.Serializers
{
    internal class XMLserialiserdemo
    {
        public static void Run(string name, int age)
        {
            try
            {
                Person person = new Person(name,age);
                string path = Path.Combine("person.xml");

                XmlSerializer ser = new XmlSerializer(typeof(Person));
                using(FileStream fs = new FileStream(path,FileMode.Create))
                {
                   
                    ser.Serialize(fs, person);
                }
                Console.WriteLine("XML Serialization done");
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
