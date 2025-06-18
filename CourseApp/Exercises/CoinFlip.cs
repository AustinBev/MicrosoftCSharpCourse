namespace CourseApp.Exercises
{
    internal class CoinFlipConditional
    {
        public void FlipTheCoin()
        {
            Random coin = new Random();

            // .Next(0,2), 2 is the upper limit, this is NOT a range
            int flip = coin.Next(0, 2);

            Console.WriteLine((flip == 0) ? "heads" : "tails");

            // another option
            //Random coin = new Random();
            //Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
        }
    }
}
