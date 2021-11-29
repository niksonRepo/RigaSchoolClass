using System.Text.Json;
using Assembly;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XMLSerializer
{
    class Program
    {
        private static readonly string FilePath = @"C:\SchoolFiles\CarXml.xml";

        static void Main(string[] args)
        {
            var car = new Car(){model = "audi", color = "black"};
            XmlSerialization(car);
            JsonSerialization(car);

            Console.ReadLine();
        }

        public static void XmlSerialization(Car car)
        {
            var list = new List<Car> {car, car};

            var serializer = new XmlSerializer(typeof(List<Car>));

            using (var fs = new FileStream(FilePath, FileMode.Open))
            {
                serializer.Serialize(fs, list);
            }

            using (var fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                var carFromFile = (List<Car>)serializer.Deserialize(fs);

                Console.WriteLine($"Car object : model = {carFromFile.FirstOrDefault().model} color = {carFromFile.FirstOrDefault().color}");

            }
        }

        public static void JsonSerialization(Car car)
        {
            var json = JsonSerializer.Serialize<Car>(car);
            Console.WriteLine(json);

            var desObject = JsonSerializer.Deserialize<Car>(json);
            
            Console.WriteLine($"Car object : model = {desObject.model} color = {desObject.color}");
        }
    }
}