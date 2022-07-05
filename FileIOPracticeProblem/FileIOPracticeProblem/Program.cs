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

        public static void Main(string[] args)
        {


            FileExist();

        }
    }
}