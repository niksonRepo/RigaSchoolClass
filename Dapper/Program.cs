namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new StudentRepository();

            var studnets = repo.GetListOfStudents();

            var liteStudents = repo.GetLiteStudents();
            Console.ReadLine();
        }
    }

}