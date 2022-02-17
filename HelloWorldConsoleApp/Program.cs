
namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringName = "Nikita";
            string nameNikita = "Name";

            var concatenateVariable1 = nameNikita + ":" + stringName;
            var concatenateVariable2 = $"{nameNikita} : {stringName}";
            var concatenateVariable3 = string.Format("{0} : {1}", nameNikita, stringName);

            var list = new List<string>(){nameNikita, stringName};
            list.Add("Item1");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Study study = new Study("ma value", "ma value");

            study.Concatanate("a", "b");

            Console.ReadLine();
        }
    }

    //Class
    public class Study
    {
        public Study(string ma, string ba)
        {
            Ma = ma;
            B = ba;
        }

        public string Ma { get; set; }
        public string B { get; set; }

        public void Concatanate(string a, string b)
        {
            var result = a + b;
        }
    }
}