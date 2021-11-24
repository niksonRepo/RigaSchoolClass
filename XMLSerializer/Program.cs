using System.Text.Json;
using Assembly;
using System.Xml.Serialization;

namespace XMLSerializer
{
    class Program
    {
        private static readonly string FilePath = @"C:\SchoolFiles\CarXml.xml";

        static void Main(string[] args)
        {
            var car = new Car(){model = "audi", color = "black"};
            //XmlSerialization(car);
            JsonSerialization(car);

            Console.ReadLine();
        }   

        public static void XmlSerialization(Car car)
        {
            var serializer = new XmlSerializer(typeof(Car));

            using (var fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, car);
            }

            using (var fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                var carFromFile = (Car)serializer.Deserialize(fs);

                Console.WriteLine($"Car object : model = {carFromFile.model} color = {carFromFile.color}");

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