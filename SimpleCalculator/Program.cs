using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertCodeHere code = new InsertCodeHere();
            do
            {
                code.Run();
            } while (calculateAgain());


        }

        private static bool calculateAgain()
        {
            bool flag = false;

            Console.WriteLine("New calculation?");
            Console.WriteLine("Type (Y)es or (N)o");
            string answer = Console.ReadLine();


            if (answer == "Y" || answer == "y")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }
    }
}
