using System;

namespace IndexersDemo
{
    class IndexersExample
    {
        public int[] intList = new int[10];
        public int this[int index]
        {
            get { return intList[index]; }
            set { intList[index] = value; }
        }
    }
    class Indexers
    {
        static void Main()
        {
            int i, j = 0;
            IndexersExample indexersTest = new IndexersExample();
            for (i = 1; i < 10; i+=2)
            {
                indexersTest[j] = i;
                j++;
            }
            for ( i = 0; i < 5; i++)
            {
                Console.WriteLine("indexersTest[{0}] is {1}", i, indexersTest[i]);
            }
        }
    }
}
