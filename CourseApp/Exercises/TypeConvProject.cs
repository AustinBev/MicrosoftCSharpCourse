using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseApp.Exercises
{
    public class TypeConvProject
    {
        public void Method1()
        {
            //int first = 2;
            //string second = "4";
            //string result = first + second;
            //Console.WriteLine(result);

            //int myInt = 3;
            //Console.WriteLine($"int: {myInt}");

            //decimal myDecimal = myInt;
            //Console.WriteLine($"decimal: {myDecimal}");

            // performing a cast
            //decimal myDecimal = 3.14m;
            //Console.WriteLine($"decimal: {myDecimal}");

            //int myInt = (int)myDecimal;
            //Console.WriteLine($"int: {myInt}");

            // narrowing conversion
            //decimal myDecimal = 1.23456789m;
            //float myFloat = (float)myDecimal;

            //Console.WriteLine($"Decimal: {myDecimal}");
            //Console.WriteLine($"Float  : {myFloat}");

            // convert a number to a string
            //int first = 5;
            //int second = 7;
            //string message = first.ToString() + second.ToString();
            //Console.WriteLine(message);

            // convert a string to an int using Parse()
            //string first = "5";
            //string second = "7";
            //int sum = int.Parse(first) + int.Parse(second);
            //Console.WriteLine(sum);

            // convert a string to int using Convert class
            //string value1 = "5";
            //string value2 = "7";
            //int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            //Console.WriteLine(result);

            // Compare casting and converting to a decimal into an int
            //int value = (int)1.5m; // casting truncates
            //Console.WriteLine(value);

            //int value2 = Convert.ToInt32(1.5m); // converting rounds up
            //Console.WriteLine(value2);

            // TryParse() method
            // It attempts to parse a string into the given numeric data type.
            // If successful, it stores the converted value in an out parameter, explained in following section.
            // It returns a bool to indicate whether the action succeeded or failed.

            string value = "102";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");
        }

        // my answer to the Type Conversion exercise
        public void TypeConversion()
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            string concatString = "";
            decimal numTotal = 0;
            foreach (string value in values)
            {
                // check if the string can be converted to an int
                if (decimal.TryParse(value, out decimal parsedValue))
                {
                    Console.WriteLine($"Converted '{value}' to decimal: '{parsedValue}'");
                    numTotal += parsedValue;
                }
                else
                {
                    concatString += value + "";
                }
            }
            Console.WriteLine($"Message: {concatString}");
            Console.WriteLine($"Total: {numTotal}");
        }

        public void Method2()
        {
            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            //int result1 = (int)Math.Round(value1 / value2);
            int result1 = Convert.ToInt32(value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            //decimal value3Decimal = (decimal)value3;
            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = (value3 / value1);
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }
    }
}

