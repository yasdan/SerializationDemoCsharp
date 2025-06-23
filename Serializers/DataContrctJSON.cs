using System.Collections;
using System.Runtime.Serialization.Json;
using SerializationDemokproject.Models;

namespace SerializationDemokproject.Serializers
{
    public static class DataContrctJSON 
    {
        public static void Run(string name, int age)
        {
            try
            {
                ContactPerson cp = new ContactPerson { Name = name, Age =age };
                string path = "contactPerson.json";

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ContactPerson));
                    serializer.WriteObject(fs, cp);
                }

                Console.WriteLine("DataContractJsonSerializer serialization done.");
            }
            catch (Exception ex)
            {
                SerializationExceptinHndler.Handle(ex);
            }
        }


    }
}