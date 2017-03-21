using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better_add_two_numbers //Project name, a folder, container
{
    class Program  //Name of your class
    {
        //global variables
        static int number1;
       static  int number2;

        //constructor to create two variables for every object
        public Program(int x, int y)
        {
            number1 = x;
            number2 = y;

                    }
        //Function that takes two values form the object and adds them together
        public int addtwonumber()
        {
            return (number1 + number2);
        }


        static void Main(string[] args)
        {
            Program p = new Program(3, 5); //created an object using the "new" keyword

            int result=  p.addtwonumber();//integer value that stores a function/method

            Console.WriteLine("\n The result " + number1 + " + " + number2 + " is " + result);
           Console.ReadLine();//stops the console from closing
        }
    }
}
