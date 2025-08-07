using System;
using System.Collections.Generic;
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
    }
}
