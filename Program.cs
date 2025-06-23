// See https://aka.ms/new-console-template for more information
using SerializationDemokproject.Serializers;

Console.WriteLine("Hello, World!Welcome to Serialization");

Console.WriteLine("\nRunning JSON Serialization...");
JSONSerilier.Run("Json user - Amar",23);

Console.WriteLine("\nRunning DataContractJson Serialization...");
DataContrctJSON.Run("Contract user - Jayram",32);

Console.WriteLine("\nRunning XML Serialization...");
XMLserialiserdemo.Run("XML User- Kaali", 25);

Console.WriteLine("\n Running SOAP Serialization...");
SOAPSeerializerdemo.Run("SOAP - Sameer", 28, "Developer");