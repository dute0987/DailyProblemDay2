using System;

namespace PrintUsername
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("hello world")

            //int val = 34;

            //double val1 = 3.4;

            //bool val2 = false;

            //char val3 = 'a';

            //string val4 = "Bridgelabz";

            //Console.WriteLine(val);

            //Console.WriteLine(val1);

            //Console.WriteLine(val2);

            //Console.WriteLine(val3);

            //Console.WriteLine(val4);

            //Console.WriteLine("the interger value is ="+ val);

            Console.WriteLine("please Enter your Name");

            string UserName = Console.ReadLine();

            if (UserName.Length>= 3)
            {
                Console.WriteLine("Hello " + UserName + ", How are you?");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }


            
        }
    }
}
