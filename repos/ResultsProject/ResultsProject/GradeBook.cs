using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;

namespace ResultsProject
{
    class GradeBook
    {
        List<Student> room = new List<Student>();

        public GradeBook()
        {
            Student s1 = new Student("Andrew Mooney", 25, 33, 47);
            Student s2 = new Student("Paul Edmond", 45, 30, 42);
            Student s3 = new Student("Nick McLean", 45, 10, 40);
            Student s4 = new Student("Philip Stevenson", 20, 50, 28);
            Student s5 = new Student("Sam Crossley", 45, 29, 40);
            
            room.Add(s1);
            room.Add(s2);
            room.Add(s3);
            room.Add(s4);
            room.Add(s5);
        }
        public void mainLogic()
        {
            bool running = true;

            while (running)
            {
                
                Console.WriteLine("\nPlease choose an option.");
                Console.WriteLine("1. View all Student Information Data.");
                Console.WriteLine("2. View all Student Exam Data.");
                Console.WriteLine("3. View all Student Percentage Data.");
                Console.WriteLine("4. Add Student Data.");
                Console.WriteLine("5. Remove Student Data.");
                Console.WriteLine("6. Search Individual Student Data.");
                Console.WriteLine("99. Quit the Application");

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
                    case 6:
                        singleStudent();
                        break;
                }
            }
        }

        public void returnStudents()
        {
            foreach(var student in room)
            {
                Console.WriteLine(student.printAllInfo());
            }
        }

        public void returnExams()
        {
            foreach(var student in room)
            {
                Console.WriteLine(student.printExamInfo());
            }
        }
        public void returnPercentage()
        {
            foreach(var student in room)
            {
                Console.WriteLine(student.printPercentageInfo());
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
                name = Console.ReadLine();

                Console.WriteLine("Biology Mark?");
                biology = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Chemistry Mark?");
                chemistry = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Physics Mark?");
                physics = Convert.ToInt32(Console.ReadLine());

                room.Add(new Student(name, physics, chemistry, biology));
                Console.WriteLine("Student " + name + " has been added.");

                Console.WriteLine("Continue adding Students?");
                Console.WriteLine("Y/N");
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
            bool notFound = false;
            while (removing)
            {
                string name;

                Console.WriteLine("What is the name of the Student you want to remove?");
                name = Console.ReadLine();

                foreach (var student in room)
                {
                    if (name == student.getName())
                    {
                        notFound = false;
                        room.Remove(student);
                        Console.WriteLine("Student record removed.");
                        break;
                    }
                    else
                    {
                        notFound = true;
                    }
                }

                if (notFound)
                {
                    Console.WriteLine("Student not found.");
                }

                Console.WriteLine("Continue removing Students?");
                Console.WriteLine("Y/N");
                string choice = Console.ReadLine();

                if (choice.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    removing = false;
                }

            }
        }

        public void singleStudent()
        {
            bool searching = true;
            bool notFound = false;
            while (searching)
            {
                Console.WriteLine("Type the first name or full name of the Student you wish to find?");
                string nameSearch = Console.ReadLine();

                Regex regex = new Regex(nameSearch);
                foreach (var student in room)
                {
                    if (student.getName().StartsWith(nameSearch))
                    {
                        notFound = false;
                        Console.WriteLine(student.printAllInfo());
                    }
                    else
                    {
                        notFound = true;
                    }
                    
                }

                if (notFound)
                {
                    Console.WriteLine("Student not found.");
                }

                Console.WriteLine("Continue searching Students?");
                Console.WriteLine("Y/N");
                string choice = Console.ReadLine();

                if (choice.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    searching = false;
                }

            }
        }

    }
}
