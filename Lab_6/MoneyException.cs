using System;
public class InvalidInput : ApplicationException
{
    public InvalidInput() : base(" Bài giảng cao cấp nhận được ít hơn 60.000 tiền lương,tiền thưởng lớn hơn 10.000") { }
} 
namespace MoneyException
{
    class PerSonName
    {
        public string name;
        public void getName()
        {
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
    class MoneyException
    {
        static void Main(string[] args)
        {
            PerSonName perSon = new PerSonName();
            perSon.getName();

            //

            Console.WriteLine("Enter your salary : " + "\n");
            try
            {
                double Salary = Convert.ToDouble(Console.ReadLine());
                if(Salary > 10000 && Salary < 60000)
                {
                    throw new InvalidInput();
                }
                
            }
            catch(InvalidInput obj)
            {
                Console.WriteLine(obj.Message);
            }
            catch(System.FormatException obj)
            {
                Console.WriteLine(obj.Message);
            }

        }
    }
}
