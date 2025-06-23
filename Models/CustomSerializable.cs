using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemokproject.Models
{
    [Serializable]
    public class CustomSerializable : ISerializable
    {
        public string Data { get; set; }

        public CustomSerializable() { }

        public CustomSerializable(string data)
        {
            Data = data;
        }

        protected CustomSerializable(SerializationInfo info, StreamingContext context)
        {
            Data = info.GetString("CustomData");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CustomData", Data);
        }

        public override string ToString() => $"CustomSerializable: {Data}";

    }
}
