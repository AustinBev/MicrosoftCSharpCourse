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
            string[] pallets = ["B14", "A11", "B12", "A13"];

            Console.WriteLine("Sorted...");
            Array.Sort(pallets); 
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
        }
    }
}
