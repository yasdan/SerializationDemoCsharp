using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SerializationDemokproject.Models;

namespace SerializationDemokproject.Serializers
{
    public class SOAPSeerializerdemo
    {
        public static void Run(string name, int age, string position)
        {
            try
            {
                Employee employee = new Employee(name, age, position);
                string path = Path.Combine("employee.xml");
                XmlTypeMapping mytypemapping = new SoapReflectionImporter().ImportTypeMapping(typeof(Employee));
                XmlSerializer serializer = new XmlSerializer(mytypemapping);
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                   serializer.Serialize(fs, employee);
                }
                Console.WriteLine("SOAP Serialization done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
