namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs.");

            Console.WriteLine("Select option \n1.Flip Coin \n2.Leap Year \n3.Power of 2 \n4.Harmonic Number");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1: FlipCoin.CoinFlip();
                    break;
                case 2: LeapYear.LeapYr();
                    break;
                case 3: PowerOfTwo.PwrOfTwo();
                    break;
                case 4: HarmonicNo.HarmonicNumber();
                    break;

                default: Console.WriteLine("Invalid Choice");
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

        public class LeapYear
        {
            public static void LeapYr()
            {
                Console.WriteLine("Enter Year :");
                string str = Console.ReadLine();
                int length = str.Length;

                if (length != 4)
                {
                    Console.WriteLine("You must enter 4 digit number. Try Again.");
                }
                else
                {
                    int Year = Convert.ToInt32(str);

                    if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                    {
                        Console.WriteLine("{0} is leap year.", Year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not leap year.", Year);
                    }


                }

            }
        }

        public class PowerOfTwo
        {
            public static void PwrOfTwo()
            {
                int num = 2;
                int power = 1;
                int i = 1;
                Console.WriteLine("Enter the Power: ");
                int p = Convert.ToInt32(Console.ReadLine());

                if (p >= 0 && p < 31)
                {
                    for (i = 1; i <= p; i++)
                    {
                        power = power * num;
                        Console.WriteLine(power);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter power between 0-31");
                }
            }
        }

        public class HarmonicNo
        {
            public static void HarmonicNumber()
            {
                Console.WriteLine("Which Harmonic Number you want: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int i = 1;
                decimal harNo = 0;

                for (i = 1; i <= n; i++)
                {
                    harNo = harNo + (1 / (decimal)i);
                }

                Console.WriteLine("Harmonic Number is " + harNo);
            }
        }
    }

}