// See https://aka.ms/new-console-template for more information

using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace Module_7 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        private const string FileName = "TestData.txt";
        private const string SourcePath = @"C:\SchoolFiles\";
        private const string TargetPath = @"C:\SchoolFiles\targetPath";
        private const string FilePath = @"C:\SchoolFiles\TestData.txt";

        public static void Main(string[] args)
        {
            try
            {
                //CreateDirectoryIfNotExists();
                //CreateFileIfNotExists();
                //GetAllDirectories();
                //GetAllFilesInDirectory();
                //GetFileInfo();
                RewriteFileAndNewLine();
                //WriteBytesToFile();
                //ReadFileWithStream();
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine("Exception message: " + exception);
            } 
            catch (FileLoadException exception)
            {
                Console.WriteLine("Exception message: " + exception);
            } 
            catch (FileNotFoundException exception)
            {
                Console.WriteLine("Exception message: " + exception);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception message: " + exception);
            }

            Console.ReadLine();
        }

        private static void CreateDirectoryIfNotExists()
        {
            if (!Directory.Exists(TargetPath))
            {
                Directory.CreateDirectory(TargetPath);
            }
        }

        public static void CreateFileIfNotExists()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
        }

        public static void WritingAllFileText()
        {
            string fileContent = "Line 1: Hello World\nLine 2: Hello World";

            File.WriteAllText(FilePath, fileContent);// writes content to file
        }

        public static void WriteAllFileLines()
        {
            string[] stringArray = { "Line 1", "Line 2", "Line 3" };

            File.WriteAllLines(FilePath, stringArray);// writes array item to file
        }

        public static void WriteBytesToFile()
        {
            string content = "Good day\nBad day\nSuny day";
            var contentInBytes = Encoding.ASCII.GetBytes(content);
            
            using (FileStream fileStream = File.OpenWrite(FilePath))
            {
                fileStream.Write(contentInBytes, 0, contentInBytes.Length);
            }
        }

        public static void ConvertStringToBytesAndWriteDataToFile()
        {
            string text = "Today is very windy. Please stay at home";
            byte[] data = Encoding.ASCII.GetBytes(text);

            File.WriteAllBytes(FilePath, data);//Creates a new file if not exists
        }

        public static void DeleteFileIfExists()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }

        public static void GetAllDirectories()
        {
            Directory.GetDirectories(SourcePath).ToList().ForEach(Console.WriteLine);
            Console.WriteLine(Environment.NewLine);
        }

        public static void GetAllFilesInDirectory()
        {
            Directory.GetFiles(SourcePath).ToList().ForEach(Console.WriteLine);
            Console.WriteLine(Environment.NewLine);
        }

        public static void GetFileInfo()
        {
            var file = new FileInfo(FilePath);

            var info = @$"  
                        File directory: {file.Directory}
                        File name: {file.Name}
                        File extension: {file.Extension}
                        File size: {file.Length}
                        File creation time: {file.CreationTime}";

            Console.WriteLine(info + Environment.NewLine);
        }

        public static void ReadAllFileText()
        {
            var fileContent = File.ReadAllText(FilePath);
            Console.WriteLine(fileContent);
        }

        public static void ReadTextByLines()
        {
            foreach (var line in File.ReadLines(FilePath))
            {
                Console.WriteLine(line);
            }
        }

        public static void ReadFileWithStream()
        {
            using (FileStream fileStream = File.OpenRead(FilePath))
            {
                byte[] bytes = new byte[1024];
                var temp = new UTF8Encoding(true);

                while (fileStream.Read(bytes, 0, bytes.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(bytes));
                }
            }
        }

        public static void AppendStringToFile()
        {
            var stringContent = "Appended line";

            using(StreamWriter streamWriter = File.AppendText(FilePath))
            {
                streamWriter.WriteLine(Environment.NewLine + stringContent);
            }
        }

        public static void RewriteFileAndNewLine()
        {
            var list = File.ReadLines(FilePath).ToList();

            list.Add("New added line");

            File.WriteAllLines(FilePath, list);
        }

    }
}


