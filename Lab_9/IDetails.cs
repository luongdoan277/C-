using System;
using System.Collections.Generic;
using System.Text;

namespace Session13
{
    interface IDetails
    {
        void GetDetails();
    }
    class Students : IDetails
    {
        string stuName;
        int stuID;
        public Students(string name,int num)
        {
            stuName = name;
            stuID = num;
        }
        public void GetDetails()
        {
            Console.WriteLine(stuID + "\t" + stuName);
        }
        class GenericList<T> where T : IDetails
        {
            T[] values = new T[3];
            int count = 0;
            public void Add(T val)
            {
                values[count] = val;
                count++;
            }
            public void Display()
            {
                for (int i = 0; i < 3; i++)
                {
                    values[i].GetDetails();
                }
            }
        }
        class InterFaceConstraintDemo
        {
        //    static void Main(string[] args)
        //    {
        //        GenericList<Students> objList = new GenericList<Students>();
        //        objList.Add(new Students("Wilson", 120));
        //        objList.Add(new Students("Jack", 130));
        //        objList.Add(new Students("Peter", 140));
        //        objList.Display();
        //    }
        }
    } 
}
