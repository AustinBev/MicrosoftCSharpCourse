namespace CourseApp.Exercises
{
    internal class CoinFlipConditional
    {
        public void FlipTheCoin()
        {
            Random coin = new Random();
            int flip = coin.Next(0, 2);

            Console.WriteLine((flip == 0 ? "heads" : "tails"));
        }
    }
}
