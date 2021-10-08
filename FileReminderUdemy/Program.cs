using System;
using System.IO;

namespace FileReminderUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution for first tast is here
            var path = @"C:\Users\j.grochowski\Desktop\WorkSpace-Jakub_Grochowski\slowka.txt";
            var file2 = File.ReadAllText(path);
            String[] words = file2.Split(' ');
            
            var file =  File.ReadAllLines(path);
            int number_of_words = 0;
            //i know i should include case when there is blank line or tab as 4 spaces but its just simple program to remind me how to use basic C# 
            foreach (string line in file)
            {
                words = line.Split(' ');
                number_of_words = number_of_words + words.Length;
                //foreach(string word in words)
                //{
                //    System.Console.WriteLine(word);
                //}

            }

            System.Console.WriteLine("Number of words in slowka.txt file: " + number_of_words);
            
        }
    }
}
