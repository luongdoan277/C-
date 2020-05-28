using System;

namespace Person
{
    abstract class TestPerson
    {
        protected string name, phone, email;
        protected TestPerson(String name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
        public string PName
        {
            get { return name; }
            set { name = value; }
        }
        public string PPhone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string PEmail
        {
            get { return email; }
            set { email = value; }
        }
        
    }
}
