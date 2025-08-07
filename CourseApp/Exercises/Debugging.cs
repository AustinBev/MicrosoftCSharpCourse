using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Exercises
{
    public class Debugging
    {
        public void Method1()
        {
            string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

            int studentCount = students.Length;

            Console.WriteLine("The final name is: " + students[studentCount - 1]);
        }

        public void Method2()
        {
            /* 
            This code uses a names array and corresponding methods to display
            greeting messages
            */

            string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

            string messageText = "";

            foreach (string name in names)
            {
                if (name == "Sophia")
                    messageText = SophiaMessage();
                else if (name == "Andrew")
                    messageText = AndrewMessage();
                else if (name == "AllGreetings")
                    messageText = SophiaMessage() + "\n\r" + AndrewMessage();

                Console.WriteLine(messageText + "\n\r");
            }

            bool pauseCode = true;
            while (pauseCode == true) ;

            static string SophiaMessage()
            {
                return "Hello, my name is Sophia.";
            }

            static string AndrewMessage()
            {
                return "Hi, my name is Andrew. Good to meet you.";
            }
        }

        public void ProcessProducts()
        {
            int productCount = 2000;
            string[,] products = new string[productCount, 2];

            LoadProducts(products, productCount);

            for (int i = 0; i < productCount; i++)
            {
                string result = Process1(products, i);

                if (result != "obsolete")
                {
                    result = Process2(products, i);
                }
            }

            bool pauseCode = true;
            while (pauseCode == true) ;
        }

        // Helper methods as private static

        private static void LoadProducts(string[,] products, int productCount)
        {
            Random rand = new Random();

            for (int i = 0; i < productCount; i++)
            {
                int num1 = rand.Next(1, 10000) + 10000;
                int num2 = rand.Next(1, 101);

                string prodID = num1.ToString();

                if (num2 < 91)
                {
                    products[i, 1] = "existing";
                }
                else if (num2 == 91)
                {
                    products[i, 1] = "new";
                    prodID = prodID + "-n";
                }
                else
                {
                    products[i, 1] = "obsolete";
                    prodID = prodID + "-0";
                }

                products[i, 0] = prodID;
            }
        }

        private static string Process1(string[,] products, int item)
        {
            Console.WriteLine($"Process1 message - working on {products[item, 1]} product");
            return products[item, 1];
        }

        private static string Process2(string[,] products, int item)
        {
            Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
            if (products[item, 1] == "new")
                Process3(products, item);

            return "continue";
        }

        private static void Process3(string[,] products, int item)
        {
            Console.WriteLine($"Process3 message - processing product information for 'new' product");
        }

        public void DebugChallenge1()
        {
            /*  
            This code instantiates a value and then calls the ChangeValue method
            to update the value. The code then prints the updated value to the console.
            */
            int x = 5;
            x = ChangeValue(x);

            Console.WriteLine(x);

            int ChangeValue(int value)
            {
                value = 10;
                return value;
            }
        }
    }
}
