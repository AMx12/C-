using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace ResultsProject
{
    class GradeBook
    {
        List<Student> room = new List<Student>();
        SpeechSynthesizer s = new SpeechSynthesizer();

            // Student s1 = new Student("Andrew Mooney", 25, 33, 47);
            // Student s2 = new Student("Paul Edmond", 45, 30, 42);
            // Student s3 = new Student("Nick McLean", 45, 10, 40);
            // Student s4 = new Student("Philip Stevenson", 20, 50, 28);
            // Student s5 = new Student("Sam Crossley", 45, 29, 40);
            // 
            // room.Add(s1);
            // room.Add(s2);
            // room.Add(s3);
            // room.Add(s4);
            // room.Add(s5);
        

        public void mainLogic()
        {
            bool running = true;

            while (running)
            {
                
                Console.WriteLine("Please choose an option.");
                Console.WriteLine("1. View all Student Information Data.");
                Console.WriteLine("2. View all Student Exam Data.");
                Console.WriteLine("3. View all Student Percentage Data.");
                Console.WriteLine("4. Add Student Data.");
                Console.WriteLine("5. Remove Student Data.");

                s.Speak("Please choose an option.");
                s.Speak("1. View all Student Information Data.");
                s.Speak("2. View all Student Exam Data.");
                s.Speak("3. View all Student Percentage Data.");
                s.Speak("4. Add Student Data.");
                s.Speak("5. Remove Student Data.");

                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        returnStudents();
                        break;
                    case 2:
                        returnExams();
                        break;
                    case 3:
                        returnPercentage();
                        break;
                    case 4:
                        addStudent();
                        break;
                    case 5:
                       removeStudent();
                        break;

                }
            }
        }

        public void returnStudents()
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            for (var i = 0; i < room.Count; i++)
            {
                Console.WriteLine(room[i].printAllInfo());
                s.Speak(room[i].printAllInfo());
            }
        }

        public void returnExams()
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            for (var i = 0; i < room.Count; i++)
            {
                Console.WriteLine(room[i].printExamInfo());
                s.Speak(room[i].printExamInfo());
            }
        }
        public void returnPercentage()
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            for (var i = 0; i < room.Count; i++)
            {
                Console.WriteLine(room[i].printPercentageInfo());
                s.Speak(room[i].printPercentageInfo());
            }
        }

        public void addStudent()
        {
            bool creating = true;

            string name;
            int biology;
            int chemistry;
            int physics;

            while (creating)
            {
                Console.WriteLine("What is the Student's name?");
                s.Speak("What is the Student's name?");
                name = Console.ReadLine();
                Console.WriteLine("Biology Mark?");
                s.Speak("Biology Mark?");
                biology = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Chemistry Mark?");
                s.Speak("Chemistry Mark?");
                chemistry = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Physics Mark?");
                s.Speak("Physics Mark?");
                physics = Convert.ToInt32(Console.ReadLine());

                room.Add(new Student(name, physics, chemistry, biology));
                Console.WriteLine("Student " + name + " has been added.");
                s.Speak("Student " + name + " has been added.");

                Console.WriteLine("Continue adding Students?");
                Console.WriteLine("Y/N");
                s.Speak("Continue adding Students?");
                string choice = Console.ReadLine();
                if (choice.Equals("n" , StringComparison.InvariantCultureIgnoreCase))
                {
                    creating = false;
                }

            }


        }

        public void removeStudent()
        {
            bool removing = true;
            while (removing)
            {
                string name;

                Console.WriteLine("What is the name of the Student you want to remove?");
                s.Speak("What is the name of the Student you want to remove?");
                name = Console.ReadLine();
                foreach (var student in room)
                {
                    if (name == student.getName())
                    {
                        room.Remove(student);
                        Console.WriteLine("Student record removed.");
                        s.Speak("Student record removed.");
                    } else
                    {
                        Console.WriteLine("No student of that name in book.");
                        s.Speak("No student of that name in book.");
                    }
                    break;
                }

                Console.WriteLine("Continue removing Students?");
                Console.WriteLine("Y/N");
                s.Speak("Continue removing Students?");
                string choice = Console.ReadLine();
                if (choice.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    removing = false;
                }

            }
        }

    }
}
