using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAppl
{
    public delegate string MyDel(string str);
    class EventDelegate
    {
        event MyDel MyEvent;

        public EventDelegate()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string userName)
        {
            return "Welcome" + userName;
        }
        static void Main(string args)
        {
            EventDelegate obj1 = new EventDelegate();
            string result = obj1.MyEvent("Tutorial Ponit");
            Console.WriteLine(result);
        }
    }
}
