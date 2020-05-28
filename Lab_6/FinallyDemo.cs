using System;
using System.IO;

namespace ExcepHanding4
{
    class FinallyDemo
    {
       static void Main(String [] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;
            try
            {
                //mo file de du lieu
                outStream = File.OpenWrite("DestinationFile.txt");
                //mo file de doc du lieu
                inStream = File.OpenRead("BogusInputFile.txt");
                //cac cau lenh doc du lieu tu file

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if(outStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("OutStream closed");
                }
                if(inStream != null)
                {
                    inStream.Close();
                    Console.WriteLine("inStream closed");
                }
            }
        }
    }
}
