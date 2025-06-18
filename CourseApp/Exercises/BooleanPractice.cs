namespace CourseApp.Exercises
{
    public class BooleanClass
    {
        public void BooleanPractice()
        {
            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
        }

        public void conditionalOperator()
        {
            int saleAmount = 1001;

            // How to return with a variable
            int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {discount}");

            // how to return with Console in single-liner
            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

        }
    }
}