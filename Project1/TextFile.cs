using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project1
{
    internal class TextFile
    {
        string textFile = @"C:\Users\jarmo\source\repos\Project1\PlikTxt.txt";
        public void ReadAllText()
        {
            string[] lines = File.ReadAllLines(textFile);
            if (File.Exists(textFile))
            {
                foreach (string line in lines)
                    Console.WriteLine(line);
            }
        }
        public void ReadTheLine(int numberOfline)
        {
            string[] lines = File.ReadAllLines(textFile);
            Console.WriteLine(lines[numberOfline - 1]);
        }
        public void AddAllTextToFile(string text)
        {
            File.AppendAllText(textFile, text + Environment.NewLine);
        }
        public void AddLineToFile(int numberOfline, string text)
        {
            Console.WriteLine(textFile);
            string[] lines = File.ReadAllLines(textFile);
            string[] extLines = new string[lines.Length + 1];
            for (int i = 0; i <= lines.Length; i++)
            {
                if (i < numberOfline)
                {
                    extLines[i] = lines[i];
                }
                else if (i == numberOfline)
                {
                    extLines[i] = text;
                }
                else if (i > numberOfline)
                {
                    extLines[i] = lines[i - 1];
                }
            }
            File.Delete(textFile);
            File.AppendAllLines(textFile, extLines);
        }
        //todo: creating delete function
    }
}
