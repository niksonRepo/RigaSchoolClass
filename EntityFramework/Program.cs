
using EntityFramework.Context;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var students1 = GetStudents();
            students1.ForEach( x=> Console.WriteLine(x.Name));

            AddStudentToDataBase();

            var students = GetStudents();
            students.ForEach( x=> Console.WriteLine(x.Name));

            UpdateStudent();
            Console.ReadLine();
        }

        public static List<Students> GetStudents()
        {
            List<Students> students;
            
            using (var context = new UniversityDbContext())
            {
                students = context.Students.ToList();
            }

            return students;
        }

        public static void AddStudentToDataBase()
        {
            var newStudent = new Students()
            {
                Name = "asd",
                Surname = "asdsad",
                Age = 21,
                Gender = "male",
                UniversityId = 1
            };

            using (var context = new UniversityDbContext())
            {
                context.Students.Add(newStudent);
                context.SaveChanges();
            }
        }

        public static void UpdateStudent()
        {
            using (var context = new UniversityDbContext())
            {
                var student = context.Students.FirstOrDefault(x => x.Name == "John");
                
                if (student != null)
                {
                    student.Age = 12;

                    context.Update(student);
                    context.SaveChanges();
                }

            }
        }
    }

}