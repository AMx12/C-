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
        public string biologyPass;
        public string chemistryPass;
        public string physicsPass;
        public float percentage;
        public int total;
        public string pass;

        public Student(string name, int physicsMark, int chemistryMark, int biologyMark)
        {
            this.name = name;
            this.biologyMark = biologyMark;
            this.chemistryMark = chemistryMark;
            this.physicsMark = physicsMark;
            this.total = biologyMark + chemistryMark + physicsMark;
            this.percentage = (total * 100) / 150;
            if (biologyMark >=30 && chemistryMark >= 30 && physicsMark >= 30) { pass = "Passed"; } else { pass = "Failed"; }
            if (biologyMark >= 30) { biologyPass = " Passed"; } else { biologyPass = " Failed"; }
            if (chemistryMark >= 30) {chemistryPass = " Passed";} else {chemistryPass = " Failed";}
            if (physicsMark >= 30) {physicsPass = " Passed";} else {physicsPass = " Failed";}
        }

        public string printAllInfo()
        {
            return "\n Name: " + name + "\n Overall: " + pass +  "\n Percentage: " + percentage + "%" + "\n Total: " + total + "\n Biology: " + biologyMark + "/50" + biologyPass + "\n Chemistry: " + chemistryMark + "/50" + biologyPass + "/50" + chemistryPass + "\n Physics: " + physicsMark + "/50" + physicsPass;
        }

        public string printExamInfo()
        {
            return "\n Name: " + name + "\n Overall: " + pass + "\n Total: " + total + "\n Biology: " + biologyMark + "/50" + biologyPass + "\n Chemistry: " + chemistryMark + "/50" + chemistryPass + "\n Physics: " + physicsMark + "/50" + physicsPass;
        }                                   
                                            
        public string printPercentageInfo() 
        {                                   
            return "\n Name: " + name + "\n Overall: " + pass + "\n Percentage: " + percentage + "%";
        }

        public string getName()
        {
            return name;
        }
    }
}
