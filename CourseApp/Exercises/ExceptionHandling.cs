using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Exercises
{
    public class ExceptionHandling
    {
        public void Method1()
        {
            try
            {
                /*
                The try code block contains the guarded code that may cause an exception.
                If the code within a try block causes an exception, the exception is handled by a corresponding catch block.
                */
            }
            catch
            {
                /*
                The catch code block contains the code that's executed when an exception is caught.
                The catch block can handle the exception, log it, or ignore it.
                A catch block can be configured to execute when any exception type occurs, or only when a specific type of exception occurs.
                */
            }
            finally
            {
                /*
                The finally code block contains code that executes whether an exception occurs or not.
                The finally block is often used to clean up any resources that are allocated in a try block.
                For example, ensuring that a variable has the correct or required value assigned to it.
                */
            }



            // example
            try
            {
                // Step 1: code execution begins
                try
                {
                    // Step 2: an exception occurs here
                }
                finally
                {
                    // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
                }

            }
            catch // Step 3: the system finds a catch clause that can handle the exception
            {
                // Step 5: the system transfers control to the first line of the catch code block
            }
        }

        public void ArrayTypeMismatchException()
        {
            string[] names = { "Dog", "Cat", "Fish" };
            Object[] objs = (Object[])names;

            Object obj = (Object)13;
            objs[2] = obj; // ArrayTypeMismatchException occurs. Trying to store a numeric value in a string array
        }

        public void DivideByZeroException()
        {
            int number1 = 3000;
            int number2 = 0;
            Console.WriteLine(number1 / number2); // DivideByZeroException occurs. Performing integer division
        }

        public void IndexOutOfRangeException()
        {
            int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
            int[] values2 = new int[6];

            values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs. attempting to assign the last element of the values1 array to the last element of the values2 array
        }

        public void NullReferenceException()
        {
            int[] values = null;
            for (int i = 0; i <= 9; i++) // attempting to access an element of a null array
                values[i] = i * 2; 

            string? lowCaseString = null;
            Console.WriteLine(lowCaseString.ToUpper()); // attempting to access a method of a null string.
        }

        public void OverflowException()
        {
            decimal x = 400;
            byte i;

            i = (byte)x; // OverflowException occurs. when attempting to convert a decimal value of 400 to a byte variable
            Console.WriteLine(i);
        }

        public void TryCatch()
        {
            //double float1 = 3000.0;
            //double float2 = 0.0;
            //int number1 = 3000;
            //int number2 = 0;

            //try
            //{
            //    Console.WriteLine(float1 / float2);
            //    Console.WriteLine(number1 / number2);
            //}
            //catch
            //{
            //    Console.WriteLine("An exception has been caught");
            //}
            //Console.WriteLine("Exit program");

            try
            {
                Process1();
            }
            catch
            {
                Console.WriteLine("An exception has occurred");
            }

            Console.WriteLine("Exit program");

            static void Process1()
            {
                try
                {
                    WriteMessage();
                }
                catch
                {
                    Console.WriteLine("Exception caught in Process1");
                }
            }

            static void WriteMessage()
            {
                double float1 = 3000.0;
                double float2 = 0.0;
                int number1 = 3000;
                int number2 = 0;

                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }
        }



        public void CatchSpecificExceptions()
        {
            checked
            {
                try
                {
                    int num1 = int.MaxValue;
                    int num2 = int.MaxValue;
                    int result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
                }
            }

            try
            {
                string? str = null;
                int length = str.Length;
                Console.WriteLine("String Length: " + length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: The reference is null. " + ex.Message);
            }

            try
            {
                int[] numbers = new int[5];
                numbers[5] = 10;
                Console.WriteLine("Number at index 5: " + numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Index out of range. " + ex.Message);
            }

            try
            {
                int num3 = 10;
                int num4 = 0;
                int result2 = num3 / num4;
                Console.WriteLine("Result: " + result2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
            }

            Console.WriteLine("Exiting program.");
        }

        public void CreateAndThrowExceptions()
        {
            /*
            ArgumentException or ArgumentNullException: Use these exception types when a method or constructor is called with an invalid argument value or null reference.
            InvalidOperationException: Use this exception type when the operating conditions of a method don't support the successful completion of a particular method call.
            NotSupportedException: Use this exception type when an operation or feature is not supported.
            IOException: Use this exception type when an input/output operation fails.
            FormatException: Use this exception type when the format of a string or data is incorrect.
            */

            string[][] userEnteredValues = new string[][]
            {
                    new string[] { "1", "two", "3"},
                    new string[] { "0", "1", "2"}
            };

            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    BusinessProcess1(userEntries);
                }
                catch (Exception ex)
                {
                    if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            static void BusinessProcess1(string[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    try
                    {
                        valueEntered = int.Parse(userValue);

                        // completes required calculations based on userValue
                        // ...
                    }
                    catch (FormatException)
                    {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    }
                }
            }
        }

        public void CoverAllExceptions()
        {
            try
            {
                OperatingProcedure1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exiting application.");
            }

            static void OperatingProcedure1()
            {
                string[][] userEnteredValues = new string[][]
                {
                new string[] { "1", "two", "3"},
                new string[] { "0", "1", "2"}
                };

                foreach (string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        BusinessProcess1(userEntries);
                    }
                    catch (Exception ex)
                    {
                        if (ex.StackTrace.Contains("BusinessProcess1"))
                        {
                            if (ex is FormatException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Corrective action taken in OperatingProcedure1");
                            }
                            else if (ex is DivideByZeroException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                                // re-throw the original exception
                                throw;
                            }
                            else
                            {
                                // create a new exception object that wraps the original exception
                                throw new ApplicationException("An error occurred - ", ex);
                            }
                        }
                    }

                }
            }

            static void BusinessProcess1(string[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    try
                    {
                        valueEntered = int.Parse(userValue);

                        checked
                        {
                            int calculatedValue = 4 / valueEntered;
                        }
                    }
                    catch (FormatException)
                    {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    }
                    catch (DivideByZeroException)
                    {
                        DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
                        throw unexpectedDivideByZeroException;

                    }
                }
            }
        }

        public void CoverAllExceptions2()
        {
            Console.Write("Enter the lower bound: ");
            int lowerBound = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the upper bound: ");
            int upperBound = int.Parse(Console.ReadLine()!);

            decimal averageValue;
            bool exit = false;

            do
            {
                try
                {
                    // Calculate the sum of the even numbers between the bounds
                    averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

                    // Display the result to the user
                    Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

                    exit = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("An error has occurred.");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"The upper bound must be greater than {lowerBound}");
                    Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
                    string? userResponse = Console.ReadLine();
                    if (userResponse.ToLower().Contains("exit"))
                    {
                        exit = true;
                    }
                    else
                    {
                        exit = false;
                        upperBound = int.Parse(userResponse);
                    }
                }
            } while (exit == false);

            // Local function: validate then compute. No user I/O here.
            decimal AverageOfEvenNumbers(int lower, int upper)
            {
                if (lower >= upper)
                    throw new ArgumentOutOfRangeException(nameof(upper),
                        "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");

                int sum = 0;
                int count = 0;

                for (int i = lower; i <= upper; i++)
                {
                    if ((i % 2) == 0)
                    {
                        sum += i;
                        count++;
                    }
                }

                if (count == 0)
                    throw new InvalidOperationException("No even numbers found in the specified range.");

                return (decimal)sum / count;
            }
        }

        public void ExceptionsChallenge1()
        {
            string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

            try
            {
                Workflow1(userEnteredValues);
                Console.WriteLine("'Workflow1' completed successfully.");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(ex.Message);
            }

            static void Workflow1(string[][] userEnteredValues)
            {
                foreach (string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        Process1(userEntries);
                        Console.WriteLine("'Process1' completed successfully.");
                        Console.WriteLine();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("'Process1' encountered an issue, process aborted.");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }
                }
            }

            static void Process1(String[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    bool integerFormat = int.TryParse(userValue, out valueEntered);

                    if (integerFormat == true)
                    {
                        if (valueEntered != 0)
                        {
                            checked
                            {
                                int calculatedValue = 4 / valueEntered;
                            }
                        }
                        else
                        {
                            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                        }
                    }
                    else
                    {
                        throw new FormatException("Invalid data. User input values must be valid integers.");
                    }
                }
            }
        }

        public void ExceptionsMoneyProject()
        {
            /*
            This application manages transactions at a store check-out line. The
            check-out line has a cash register, and the register has a cash till
            that is prepared with a number of bills each morning. The till includes
            bills of four denominations: $1, $5, $10, and $20. The till is used
            to provide the customer with change during the transaction. The item 
            cost is a randomly generated number between 2 and 49. The customer 
            offers payment based on an algorithm that determines a number of bills
            in each denomination. 

            Each day, the cash till is loaded at the start of the day. As transactions
            occur, the cash till is managed in a method named MakeChange (customer 
            payments go in and the change returned to the customer comes out). A 
            separate "safety check" calculation that's used to verify the amount of
            money in the till is performed in the "main program". This safety check
            is used to ensure that logic in the MakeChange method is working as 
            expected.
            */


            string? readResult = null;
            bool useTestData = false;

            Console.Clear();

            int[] cashTill = new int[] { 0, 0, 0, 0 };
            int registerCheckTillTotal = 0;

            // registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
            int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

            int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
            int testCounter = 0;

            LoadTillEachMorning(registerDailyStartingCash, cashTill);

            registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

            // display the number of bills of each denomination currently in the till
            LogTillStatus(cashTill);

            // display a message showing the amount of cash in the till
            Console.WriteLine(TillAmountSummary(cashTill));

            // display the expected registerDailyStartingCash total
            Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
            Console.WriteLine();

            var valueGenerator = new Random((int)DateTime.Now.Ticks);

            int transactions = 100;

            if (useTestData)
            {
                transactions = testData.Length;
            }

            while (transactions > 0)
            {
                transactions -= 1;
                int itemCost = valueGenerator.Next(2, 50);

                if (useTestData)
                {
                    itemCost = testData[testCounter];
                    testCounter += 1;
                }

                int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
                int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
                int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
                int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

                // display messages describing the current transaction
                Console.WriteLine($"Customer is making a ${itemCost} purchase");
                Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
                Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
                Console.WriteLine($"\t Using {paymentFives} five dollar bills");
                Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

                try
                {
                    // MakeChange manages the transaction and updates the till 
                    MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

                    // Backup Calculation - each transaction adds current "itemCost" to the till
                    registerCheckTillTotal += itemCost;
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Could not make transaction: {e.GetType().Name}: {e.Message}");
                }

                Console.WriteLine(TillAmountSummary(cashTill));
                Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
                Console.WriteLine();
            }

            Console.WriteLine("Press the Enter key to exit");
            do
            {
                readResult = Console.ReadLine();

            } while (readResult == null);


            static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
            {
                cashTill[0] = registerDailyStartingCash[0, 1];
                cashTill[1] = registerDailyStartingCash[1, 1];
                cashTill[2] = registerDailyStartingCash[2, 1];
                cashTill[3] = registerDailyStartingCash[3, 1];
            }


            static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
            {
                cashTill[3] += twenties;
                cashTill[2] += tens;
                cashTill[1] += fives;
                cashTill[0] += ones;

                int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
                int changeNeeded = amountPaid - cost;

                if (changeNeeded < 0)
                    throw new InvalidOperationException("The till is unable to make change for the cash provided.");

                Console.WriteLine("Cashier Returns:");

                while ((changeNeeded > 19) && (cashTill[3] > 0))
                {
                    cashTill[3]--;
                    changeNeeded -= 20;
                    Console.WriteLine("\t A twenty");
                }

                while ((changeNeeded > 9) && (cashTill[2] > 0))
                {
                    cashTill[2]--;
                    changeNeeded -= 10;
                    Console.WriteLine("\t A ten");
                }

                while ((changeNeeded > 4) && (cashTill[1] > 0))
                {
                    cashTill[1]--;
                    changeNeeded -= 5;
                    Console.WriteLine("\t A five");
                }

                while ((changeNeeded > 0) && (cashTill[0] > 0))
                {
                    cashTill[0]--;
                    changeNeeded -= 1;
                    Console.WriteLine("\t A one");
                }

                if (changeNeeded > 0)
                    throw new InvalidOperationException("Can't make change. Do you have anything smaller?");

            }

            static void LogTillStatus(int[] cashTill)
            {
                Console.WriteLine("The till currently has:");
                Console.WriteLine($"{cashTill[3] * 20} in twenties");
                Console.WriteLine($"{cashTill[2] * 10} in tens");
                Console.WriteLine($"{cashTill[1] * 5} in fives");
                Console.WriteLine($"{cashTill[0]} in ones");
                Console.WriteLine();
            }

            static string TillAmountSummary(int[] cashTill)
            {
                return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

            }

        }
    }
}
