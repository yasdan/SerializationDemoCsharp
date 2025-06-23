using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemokproject
{
    public class SerializationExceptinHndler
    {
        public static void Handle(Exception ex)
        {
            Console.WriteLine("Serialization Error: " + ex.Message);
        }
    }
}
