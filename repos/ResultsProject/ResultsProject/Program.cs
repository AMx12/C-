using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ResultsProject
{
    class Program
    {



        static void Main(string[] args)
        {
            GradeBook gb = new GradeBook();
            SpeechSynthesizer s = new SpeechSynthesizer();
            Console.WriteLine("Welcome to the Student Exam Results Book.");
            s.Speak("Welcome Commander. This is the Student Exam Results Book.");

            gb.mainLogic();

            
        }
    }
}
