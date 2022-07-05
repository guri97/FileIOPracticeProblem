using System;
using System.IO;
namespace FileIO

{
    class Program
    {
        public static void FileExist()
        {
            string InputFile = @"C:\Users\GURPREET SINGH\Desktop\VisualStudio\FileIOTextFile";
            if (File.Exists(InputFile))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("not Exist");
            }
        }
        public static void ReadFile()
        {
            string InputFile = @"C:\Users\GURPREET SINGH\Desktop\VisualStudio\FileIOTextFile";
            using (StreamReader read = new StreamReader(InputFile))
            {
                string s = "";
                while ((s = read.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                read.Close();
            }
        }
        public static void CopyFile()
        {
            string path = @"C:\Users\GURPREET SINGH\Desktop\VisualStudio\FileIOTextFile";
            string CopyPath = @"C:\Users\GURPREET SINGH\Desktop\VisualStudio\FileIOTextFile";
            File.Copy(path, CopyPath);
        }
        public static void DeleteFile()
        {
            string Path = @"C:\Users\GURPREET SINGH\Desktop\VisualStudio\FileIOTextFile";
            File.Delete(Path);
            Console.WriteLine("File deleted sucessfully");
        }
        public static void Main(string[] args)
        {


            FileExist();
            ReadFile();
            CopyFile();
            DeleteFile();
        }
    }
}