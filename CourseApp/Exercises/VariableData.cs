﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Exercises
{
    public class VariableData
    {
        public void VariableDataPractice()
        {
            //Console.WriteLine("Signed integral types:");

            //Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            //Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            //Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            //Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            //Console.WriteLine("");
            //Console.WriteLine("Unsigned integral types:");

            //Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            //Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            //Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            //Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            //Console.WriteLine("");
            //Console.WriteLine("Floating point types:");
            //Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            //Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            //Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            //int[] data;
            //data = new int[3];
            int[] data = new int[3];

            string shortenedString = "Hello World";
            Console.WriteLine(shortenedString);

            int val_A = 2;
            int val_B = val_A;
            val_B = 5;

            Console.WriteLine("--Value Types--");
            Console.WriteLine($"val_A: {val_A}");
            Console.WriteLine($"val_B: {val_B}");

            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            ref_B[0] = 5;

            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");

            /*
            int for most whole numbers
            decimal for numbers representing money
            bool for true or false values
            string for alphanumeric value

            byte: working with encoded data that comes from other computer systems or using different character sets.
            double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
            System.DateTime for a specific date and time value.
            System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
            */
        }
    }
}
