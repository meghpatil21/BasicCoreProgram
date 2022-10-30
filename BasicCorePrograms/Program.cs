namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs.");

            Console.WriteLine("Select option \n1.Flip Coin");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1: FlipCoin.CoinFlip();
                    break;

            }
          


        }

        public class FlipCoin
        {
            public static void CoinFlip()
            {
                Console.WriteLine("How many times coin should be flip :");
                int n = Convert.ToInt32(Console.ReadLine());
                int i;
                int headCount = 0;
                int tailCount = 0;
                int headPercent;

                if (n <= 0)
                {
                    Console.WriteLine("Invalid Choice");
                }
                else
                {
                    for (i = 1; i <= n; i++)
                    {
                        Random random = new Random();
                        double coin = random.NextDouble();

                        if (coin < 0.5)
                        {
                            Console.WriteLine("Tails");
                            tailCount++;
                        }
                        else
                        {
                            Console.WriteLine("Heads");
                            headCount++;
                        }
                    }
                    Console.WriteLine();
                    headPercent = headCount * 100 / n;
                    Console.WriteLine("Head Percent: " + headPercent);
                    Console.WriteLine("Tail Percent: " + (100 - headPercent));

                }
            }
        }
    }

}