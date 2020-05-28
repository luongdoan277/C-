﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Session13
{
    class GeneralList<T>
    {
        protected T ItemOne;
        public GeneralList(T valOne)
        {
            ItemOne = valOne;
        }
        public virtual T GetValue()
        {
            return ItemOne;
        }
    }
    class Student<T> : GeneralList<T>
    {
        public T Value;
        public Student(T valGen, T valStu) : base(valGen)
        {
            Value = valStu;
        }
        public override T GetValue()
        {
            Console.Write(base.GetValue() + "\t\t");
            return Value;
        }
    }
    class StudentList
    {
        //public static void Main()
        //{
        //    Student<string> objStudent = new Student<string>("Patrick", "Male");
        //    Console.WriteLine("Name\t\tSex");
        //    Console.WriteLine(objStudent.GetValue());
        //}
    }
}