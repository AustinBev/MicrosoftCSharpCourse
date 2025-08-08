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
            Console.WriteLine("9. SwitchStatement");
            Console.WriteLine("10. ForLoops");
            Console.WriteLine("11. DoWhile");
            Console.WriteLine("12. ConditionalBranching");
            Console.WriteLine("13. VariableDataPractice");
            Console.WriteLine("14. Type Conversion Project");
            Console.WriteLine("15. Helper Methods");
            Console.WriteLine("16. String Formatting");
            Console.WriteLine("17. IndexOf() Substring() Replace() Remove()");
            Console.WriteLine("18. VariableData");
            Console.WriteLine("19. Challenge Project");
            Console.WriteLine("20. Methods Practice");
            Console.WriteLine("21. Petting Zoo");
            Console.WriteLine("22. Minigame");
            Console.WriteLine("23. Debugging");
            Console.WriteLine("24. Exception Handling");
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
                    new SwitchStatement().SwitchSKU();
                    break;
                case "10":
                    new ForLoops().LoopMethod();
                    new ForLoops().LoopMethod2();
                    new ForLoops().ModifyArrayLoop();
                    new ForLoops().DivisibleForLoop();
                    break;
                case "11":
                    new DoWhile().DoWhileMethod();
                    new DoWhile().Method2();
                    new DoWhile().Method4();
                    break;
                case "12":
                    new ConditionalBranching().Method1();
                    break;
                case "13":
                    new VariableData().Method1();
                    break;
                case "14":
                    new TypeConvProject().Method2();
                    break;
                case "15":
                    new VariableData().Method2();
                    break;
                case "16":
                    new VariableData().StringFormatting();
                    break;
                case "17":
                    new VariableData().IndexOfSubstring();
                    break;
                case "18":
                    new VariableData().Project();
                    break;
                case "19":
                    new VariableData().ChallengeProject();
                    break;
                case "20":
                    //new MethodPractice().Method1();
                    //new MethodPractice().Method2();
                    //new MethodPractice().IpAddress();
                    //new MethodPractice().MethodChallenge1();
                    //new MethodPractice().Method3();
                    //new MethodPractice().CircleInfo();
                    //new MethodPractice().ValueOrReference();
                    //new MethodPractice().OptionalParams();
                    //new MethodPractice().DisplayEmailsChallenge();
                    //new MethodPractice().ReturnMethod3();
                    //new MethodPractice().ReturnMethodPalindrome();
                    //new MethodPractice().ReturnMethodArrays();
                    new MethodPractice().MethodChallenge2();
                    break;
                case "21":
                    new PettingZoo().Method1();
                    break;
                case "22":
                    new Minigame().Method1();
                    break;
                case "23":
                    //new Debugging().Method1();
                    //new Debugging().Method2();
                    //new Debugging().ProcessProducts();
                    new Debugging().DebugChallenge1();
                    break;
                case "24":
                    //new ExceptionHandling().Method1();
                    //new ExceptionHandling().TryCatch();
                    //new ExceptionHandling().CatchSpecificExceptions();
                    //new ExceptionHandling().CoverAllExceptions();
                    //new ExceptionHandling().CoverAllExceptions2();
                    new ExceptionHandling().ExceptionsChallenge1();
                    new ExceptionHandling().ExceptionsMoneyProject();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}
