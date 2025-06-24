using System.Xml.Linq;

namespace CourseApp.Exercises
{
    public class DoWhile
    {
        public void DoWhileMethod1()
        {
            Random random = new Random();
            int current = random.Next(1, 11);

            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

                Console.WriteLine(current);
            } while (current != 7);

            /*
            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */
        }

        public void DoWhileMethod()
        {
            Random random = new Random();

            int heroHealth = 10;
            int npcHealth = 10;

            do
            {
                int heroAttack = random.Next(1, 11);
                npcHealth -= heroAttack;
                Console.WriteLine($"Hero hits NPC for {heroAttack} damage, NPC health: {npcHealth}");
                if (npcHealth <= 0)
                {
                    Console.WriteLine("NPC is defeated!");
                    break;
                }

                int npcAttack = random.Next(1, 11);
                heroHealth -= npcAttack;
                Console.WriteLine($"Npc hits Hero for {npcAttack} damage, Hero health: {heroHealth}");
                if (heroHealth <= 0)
                {
                    Console.WriteLine("Hero is defeated!");
                    break;
                }

            } while (heroHealth > 0 && npcHealth > 0);
        }

        public void Method1()
        {
            int numericValue = 0;
            bool validNumber = false;
            string? readResult;

            do
            {
                Console.WriteLine("Enter a number between 5 and 10");
                readResult = Console.ReadLine();

                if (readResult == null)
                {
                    Console.WriteLine("Input was null. Try again.");
                    continue;
                }

                validNumber = int.TryParse(readResult, out numericValue);

                if (!validNumber)
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                }

                if (numericValue < 5 || numericValue > 10)
                {
                    Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10");
                }

            } while (!validNumber || numericValue < 5 || numericValue > 10);

            Console.WriteLine($"You entered: {numericValue}");
        }

        public void Method3()
        {
            string[] roleNames = { "Administrator", "Manager", "User" };
            bool validName = false;
            string readResult = "";
            string acceptedRole = "";

            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                readResult = Console.ReadLine();

                string readResultFixed = readResult.Trim().ToLower();

                // Check if the cleaned input matches one of the roles
                foreach (string role in roleNames)
                {
                    if (readResultFixed == role.ToLower())
                    {
                        validName = true;
                        acceptedRole = role;
                        break;
                    }
                }

                if (!validName)
                {
                    Console.WriteLine($"The role you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                }

            } while (!validName);

            Console.WriteLine($"Your input value ({acceptedRole}) has been accepted");
        }

        public void Method2()
        {
            string[] roleNames = { "Administrator", "Manager", "User" };
            bool validName = false;
            string readResult = "";
            string acceptedRole = "";
            int roleNumber = -1;

            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
                readResult = Console.ReadLine();

                string readResultFixed = readResult.Trim().ToLower();

                for (int i = 0; i < roleNames.Length; i++)
                {
                    if (readResultFixed == roleNames[i].ToLower())
                    {
                        validName = true;
                        acceptedRole = roleNames[i];
                        roleNumber = i + 1; // 1-based index
                        break;
                    }
                }

                if (!validName)
                {
                    Console.WriteLine($"The role you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User).");
                }

            } while (!validName);

            Console.WriteLine($"Your input value ({acceptedRole}) has been accepted. Role number: {roleNumber}");
        }

        public void Method4()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for (int i = 0; i < stringsCount; i++)
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf(".");

                string mySentence;

                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {

                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);

                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);

                    // remove any leading white-space from myString
                    myString = myString.TrimStart();

                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");

                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }
        }
    }
}






