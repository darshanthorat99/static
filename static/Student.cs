using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statics
{
    class Student
    {
        private int rollno;
        private string name;
        private int mark1;
        private int mark2;
        private int mark3;
        private float TOTAL;
        private float per;
        private static int count;


        public Student(string name, int mark1, int mark2, int mark3)
        {
            count++;
            this.rollno = count;
            this.name = name;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;


         }
        public void CalculateMark()
        {
            TOTAL = mark1 + mark2 + mark3;
             per = TOTAL / 3;

        }
        public override string ToString()
        {
            return $"NAME  {name} rollno {rollno}  TOTAL {TOTAL}  percentage{per}";
       }
    }
}
