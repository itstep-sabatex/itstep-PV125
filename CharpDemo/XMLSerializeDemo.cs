using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CharpDemo
{
    internal static class XMLSerializeDemo
    {
        public static void SerializeDemo()
        {
            var person = new Person { FirstName= "Semen",LastName="Semenchenko"};
            var serializer = new XmlSerializer(typeof(Person));  // (person.GetType());
            var file =  File.CreateText("person.xml");
            serializer.Serialize(file, person);
            Console.WriteLine();

        }


        public static void DesserializeDemo()
        {
            var serializer = new XmlSerializer(typeof(Person));
            var file = File.OpenText("person.xml");
            var person = (Person)serializer.Deserialize(file);
            Console.WriteLine();
        }


    }
}
