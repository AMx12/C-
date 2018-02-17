using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsProject
{
    class Student
    {
        public string name;
        public int biologyMark;
        public int chemistryMark;
        public int physicsMark;
        public float percentage;
        public int total;

        public Student(string name, int physicsMark, int chemistryMark, int biologyMark)
        {
            this.name = name;
            this.biologyMark = biologyMark;
            this.chemistryMark = chemistryMark;
            this.physicsMark = physicsMark;
            this.total = biologyMark + chemistryMark + physicsMark;
            this.percentage = (total * 100) / 150;
        }

        public string printAllInfo()
        {
            return "\n Name: " + name + "\n Percentage: " + percentage + "%" + "\n Total: " + total + "\n Biology: " + biologyMark + "\n Chemistry: " + chemistryMark + "\n Physics: " + physicsMark;
        }

        public string printExamInfo()
        {
            return "\n Name: " + name + "\n Total: " + total + "\n Biology: " + biologyMark + "\n Chemistry: " + chemistryMark + "\n Physics: " + physicsMark;
        }

        public string printPercentageInfo()
        {
            return "\n Name: " + name + "\n Percentage: " + percentage + "%";
        }

        public string getName()
        {
            return name;
        }
    }
}
