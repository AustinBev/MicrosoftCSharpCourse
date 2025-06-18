using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Exercises
{
    public class DiceIf
    {
        public void RollDice()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
            //int roll1 = 6;
            //int roll2 = 6;
            //int roll3 = 6;

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
            {
                if (roll1 == roll2 && roll2 == roll3)
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    total += 2;
                }
            }

            if (total == 7)
            {
                Console.WriteLine("You win a trip!");
            }

            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }

            else if (total >= 16)
            {
                Console.WriteLine("You win a car!");
            }

            else
            {
                Console.WriteLine("You win a kitten!");
            }

            
        }
    }

    public class fox1
    {
        public void booleanMethod()
        {
            string message = "The quick brown fox jumps over the lazy dog.";
            bool result = message.Contains("dog");
            Console.WriteLine(result);

            if (message.Contains("Fox"))
            {
                Console.WriteLine("What does the fox say?");
            }
        }
    }
}
