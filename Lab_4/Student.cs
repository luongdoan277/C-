using Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Student : TestPerson
    {
        private string program;

        public Student(String program, String name, string phone, string email) : base(name, phone, email)
        {
            this.program = program;
        }
        public override string ToString()
        {
            return "Student has: name is " + PName + ", phone is " + PPhone + ", email is " + PEmail + ", program is " + program;
        }
    }
}
