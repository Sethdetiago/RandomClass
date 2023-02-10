using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dice example
            Random dice = new Random();
            int numEyes;

            for(int i = 0; i< 10; i++)
            {
                numEyes = dice.Next(1,7);
                Console.WriteLine(numEyes);
            }*/

            /*Exercise: Create a fortune teller that randomly produces a "Yes" "No" or "Maybe"
             */
            //Prompt user for a question about their future
            Random fortune = new Random();

            Console.WriteLine("Ask me a question about your future, I will answer whether it will come to pass");
            string prediction = Console.ReadLine();

            int truth = fortune.Next(1,4);
            if(truth == 1)
            {
                Console.WriteLine("Yes");
            }
            else if(truth == 2)
            {
                Console.WriteLine("No");
            }
            else if (truth == 3)
            {
                Console.WriteLine("Maybe");
            }

            Console.ReadKey();
        }
    }
}
