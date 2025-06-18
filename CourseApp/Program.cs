// See https://aka.ms/new-console-template for more information
using CourseApp.Exercises;

namespace CourseApp
{
    internal class Program
    {
        // Where the program begins
        // static means you don't have to make an object to call this method
        // void means the method doesn't return anything
        // if we wanted to return something, we would replace void with a type (int, str)
        static void Main(string[] args)
        {
            Console.WriteLine("=== CourseApp Exercise Runner ===");
            Console.WriteLine("Select an exercise to run:");
            Console.WriteLine("1. Boolean Practice");
            Console.WriteLine("2. Dice Roll Game");
            Console.WriteLine("3. Subscription Renewal");
            Console.WriteLine("4. Fraud Order Checker");
            Console.WriteLine("5. Student Grades Report");
            Console.WriteLine("6. Coin Flip");
            Console.WriteLine("7. Permissions");
            Console.WriteLine("8. VariableScope");
            Console.WriteLine("8. SwitchStatement");
            Console.Write("Enter number: ");

            string? input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    new BooleanClass().BooleanPractice();
                    break;
                case "2":
                    new DiceIf().RollDice();
                    break;
                case "3":
                    new RenewalRate().WhenWillExpire();
                    break;
                case "4":
                    new FraudOrders().ReturnFraud();
                    break;
                case "5":
                    new StudentGrade().GenerateGrades();
                    break;
                case "6":
                    new CoinFlipConditional().FlipTheCoin();
                    break;
                case "7":
                    new Permissions().AddPerms();
                    break;
                case "8":
                    new VariableScope().CodeBlock();
                    break;
                case "9":
                    new SwitchStatement().SwitchMethod();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}
