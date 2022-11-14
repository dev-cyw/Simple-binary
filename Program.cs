using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            // varaible to see if you want to loop
            do
            {
                int Base2 = 1;
                int number = 0;
                //Delcaring and Assigning Varaibles 

                Console.WriteLine("Enter the binary");
                char[] binary = Console.ReadLine().ToCharArray();
                //Reads the text that you input and turns it into a character array

                for (int i = binary.Length; i > 0; i--)
                // Loop going backwaards for the amount of characters
                {
                    int IntChange = (int) (binary[i - 1] - '0');
                    //Converts each character into a integer 

                    number = IntChange * Base2 + number;
                    Base2 = Base2 * 2;
                    // increases the multiplier for binary and adding the other binary
                }

                Console.WriteLine(number);

                Console.WriteLine("\nDo you want to continue?");
                string Answer = Console.ReadLine();
                if (Answer == "n" || Answer == "no" || Answer == "")
                {
                    repeat = false;
                }
                else
                {
                    repeat = true;
                }
                // asks if the user wants to repeat the binary conversion
            }
            while (repeat == true);

            Console.ReadKey();

        }
    }
}
