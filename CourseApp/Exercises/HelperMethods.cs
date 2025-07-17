using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Exercises
{
    internal class HelperMethods
    {
        public void Method1()
        {
            /*
            Array.Sort() and Array.Reverse() methods are used to sort and reverse the elements of an array.
            */
            //string[] pallets = ["B14", "A11", "B12", "A13"];

            //Console.WriteLine("Sorted...");
            //Array.Sort(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            /* reverse sorted */
            //string[] pallets = ["B14", "A11", "B12", "A13"];

            //Console.WriteLine("Sorted...");
            //Array.Sort(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Reversed...");
            //Array.Reverse(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            /* Clear() and Resize() */
            string[] pallets = ["B14", "A11", "B12", "A13"];
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            /* remove using resize */
            //string[] pallets = ["B14", "A11", "B12", "A13"];
            //Console.WriteLine("");

            //Array.Clear(pallets, 0, 2);
            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Array.Resize(ref pallets, 6);
            //Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            //pallets[4] = "C01";
            //pallets[5] = "C02";

            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            /* Split() and Join() */
            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            ////string result = new string(valueArray);
            //string result = String.Join(",", valueArray);
            //Console.WriteLine(result);
            //string[] items = result.Split(',');
            //foreach (string item in items)
            //{
            //    Console.WriteLine(item);
            //}

            //string pangram = "The quick brown fox jumps over the lazy dog";
            // split with 
        }
    }
}
