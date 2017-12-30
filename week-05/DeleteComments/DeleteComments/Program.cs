using System;
using System.Collections.Generic;
using System.IO;

namespace DeleteComments
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\greenfox\corsac-basic-exam\delete-the-comments\DeleteTheComments.cs";

            FileReader(filePath);
        }

        public static void FileReader(string filePath)
        {
            string[] fileLinesArray = File.ReadAllLines(filePath);

            var newFileLinesList = new List<string>();

            for (int i = 0; i < fileLinesArray.Length; i++)
            {
                string lines = fileLinesArray[i];

                if (!lines.Contains("//"))
                {
                    newFileLinesList.Add(fileLinesArray[i]);
                }
            }

            File.WriteAllLines(filePath, newFileLinesList.ToArray());
        }
    }
}
