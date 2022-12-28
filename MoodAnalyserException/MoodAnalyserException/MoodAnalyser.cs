using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserException
{
    public class MoodAnalyser
    {
        public string message;
        //create parameterized constructor
        public MoodAnalyser(string message) 
        {
            this.message = message;//assigning value to local variable
        }
        public string MoodAnalyzer()//create method to get mood using messege
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }

    }
}
