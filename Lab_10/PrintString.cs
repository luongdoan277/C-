using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DelegateAppl
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        //delegate declaration
        public delegate void printString(string s);

        //this method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The string is: {0}", str);
        }  
        
        //this method prints to a file
        public static void WriteToFile(string s)
        {
            fs = new FileStream("c:\\message.txt", FileMode.Append, FileAccess.Write);

            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        //this method take the delegate as parameter and use it to
        //call the method as required

        public static void sendString(printString ps)
        {
            ps("Hello word");
        }

        public static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }
    }
}
