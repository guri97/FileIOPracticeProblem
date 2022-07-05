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
        public static void Main(string[] args)
        {


            FileExist();
            ReadFile();


        }
    }
}
