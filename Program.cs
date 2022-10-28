using System;

namespace Search
{
    class Program
    {
        //array to be searched
        int[] arr = new int[20];
        //number of the element in the aray
        int n;
        //get the number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of element in the array: ");
                string s = Console.ReadLine();
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 elements. \n")
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
