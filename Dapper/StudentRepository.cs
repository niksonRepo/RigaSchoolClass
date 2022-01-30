using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperProject;
using Microsoft.Data.Sqlite;

namespace Dapper
{
    public class StudentRepository
    {
        private string conStringSqlServer = "Data Source=(local); Initial Catalog=StudentsDatabase; Trusted_Connection=True;";
        private static SQLiteConnection _dbConnection;

        private static void CreateIfNotExistsAndOpenDb()
        {
            var dbFilePath = @"StudnetDatabase.sqlite";

            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            _dbConnection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;");
            _dbConnection.Open();
        } 

        public List<Students> GetListOfStudents()
        {
            var studentListQuery = "Select * From Students";

            using (var connection = new SqlConnection(conStringSqlServer))
            {
                return connection.Query<Students>(studentListQuery).ToList();
            }
        }

        public List<Students> GetLiteStudents()
        {


            CreateIfNotExistsAndOpenDb();

            var studentListQuery = @"
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Students;

CREATE TABLE Students(
	Id int IDENTITY(1,1) NOT NULL,
	Name text NULL,
	Surname text NULL,
	Primary Key (Id)
	);

CREATE TABLE Courses(
	Id int IDENTITY(1,1) NOT NULL,
	Name text NULL,
	StudentId int NOT NULL,
	Primary Key (Id),
	CONSTRAINT FK_Courses_Students FOREIGN KEY (StudentId)
    REFERENCES Students(Id)
	);

Insert Into Students
Values (1,'John','Doe');

Insert Into Courses
Values (1, 'Mathematic', 1);

";
            _dbConnection.Query(studentListQuery);

            var getStudentQuery = "Select * From Students";
            return _dbConnection.Query<Students>(getStudentQuery).ToList();

        }
    }
}
