namespace CourseApp.Exercises
{
    public class ForLoops
    {
        public void LoopMethod()
        {
            // int i = 0 is the "initializer"
            // i < 10 is the complete condition. It will continue to iterate if i < 10
            // the action to take after each iteration 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Decremented
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            // Decremented from 0 to -10
            for (int i = 0; i > -10; i--)
            {
                Console.WriteLine(i);
            }

            // Count from 0 to 50 in increments of 10
            for (int i = 0; i < 51; i += 10)
            {
                Console.WriteLine(i);

                if (i == 30)
                    break;
            }
        }

        public void LoopMethod2()
        {
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
        }

        public void ModifyArrayLoop()
        {
            string[] names = { "Alex", "Eddie", "David", "Michael" };

            for (int i = 0; i < names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);

            // or

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "David")
                {
                    names[i] = "Sammy";
                }
            }
        }

        public void DivisibleForLoop()
        {
            for (int i = 1; i < 23; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                } else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                } else
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
