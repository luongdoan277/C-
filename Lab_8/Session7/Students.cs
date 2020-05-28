using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    class Students
    {
        string _studentName = "Jame";
        string _address = "California";
        public virtual void PrintDetails()
        {
            Console.WriteLine("Student Name " + _studentName);
            Console.WriteLine("Address " + _address);
        }
    }
    class Grade : Students
    {
        string _class = "Four";
        float _percent = 71.25F;
        public override void PrintDetails()
        {
            Console.WriteLine("Class " + _class);
            Console.WriteLine("Percentage " + _percent);
        }
        //static void Main(string[] args)
        //{
        //    Students objStudent = new Students();
        //    Grade objGrade = new Grade();
        //    objStudent.PrintDetails();
        //    objGrade.PrintDetails();
        //}
    }
}
