using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.WriteLine("Give the amount of throws: ");
            string line = Console.ReadLine();
            int amount = int.Parse(line);
            Console.WriteLine("Dice is now thrown " + amount + " times");
            int number;
            int sum = 0;
            for (int i = 1; i <= amount; i++)
            {
                number = dice.Throw();
                sum = sum + number;
                 //Console.WriteLine("Dice value is {0}", number);
            }
            int average = sum/amount;
            Console.WriteLine("-average is {0}", average); 
        }
    }
}
