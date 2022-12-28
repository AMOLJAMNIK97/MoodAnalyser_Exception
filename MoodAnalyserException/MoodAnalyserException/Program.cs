using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Anlyser");
            Console.WriteLine("Enter message ");
            string message = Console.ReadLine();

            MoodAnalyser obj = new MoodAnalyser(message);
            string mood = obj.MoodAnalyzer();//calling method of class with passing user message as parameter
            Console.WriteLine("Mood :{0}", mood);
            Console.ReadLine();
        }
    }
}