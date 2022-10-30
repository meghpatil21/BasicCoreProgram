namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs.");

            Console.WriteLine("Select option \n1.Flip Coin \n2.Leap Year \n3.Power of 2 \n4.Harmonic Number \n5.Factors \n6.Quotient Remainder \n7.Swap Number \n8.Even Odd \n9.Vowel Consonant \n10.Largest Number");
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
                case 5: Factors.PrimeFactors();
                    break;
                case 6: QuotientRemainder.QuotRemainder();
                    break;
                case 7: SwapNumber.SwapTwoNo();
                    break;
                case 8: EvenOdd.OddEven();
                    break;
                case 9: VowelConsonant.VowelConson();
                    break;
                case 10: LargestNumber.LargestNo();
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

        public class Factors
        {
            public static void PrimeFactors()
            {
                Console.WriteLine("Enter non-prime Number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int i;
                for (i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {

                        while (n % i == 0)
                        {
                            n = n / i;

                        }
                        Console.WriteLine("{0} is a prime factor. ", i);
                    }
                }
            }
        }

        public class QuotientRemainder
        {
            public static void QuotRemainder()
            {
                int quotient, remainder;

                Console.WriteLine("Enter a number to be divided ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter divisor :");
                int d = Convert.ToInt32(Console.ReadLine());

                quotient = num / d;
                remainder = num % d;

                Console.WriteLine($"The quotient is {quotient} and remainder is {remainder}");
            }
        }

        public class SwapNumber
        {
            public static void SwapTwoNo()
            {
                Console.WriteLine("Enter 1st number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int temp = num1;

                num1 = num2;
                num2 = temp;

                Console.WriteLine("Your 1st number is: " + num1);
                Console.WriteLine("Your 2nd number is: " + num2);
            }
        }

        public class EvenOdd
        {
            public static void OddEven()
            {
                Console.WriteLine("Enter a Number to check odd or even: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is even.");
                }
                else
                {
                    Console.WriteLine($"{num} is odd.");
                }
            }
        }

        public class VowelConsonant
        {
            public static void VowelConson()
            {
                Console.Write("Input an Alphabet: ");
                char ch = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (ch)
                {
                    case 'A':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'I':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'O':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'U':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'E':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            }
        }

        public class LargestNumber
        {
            public static void LargestNo()
            {
                Console.WriteLine("Welcome to Three Number Comparator");
                Console.WriteLine();
                Console.WriteLine("Enter 1st no: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 2nd no: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 3rd no: ");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine("Largest number is " + n1);
                }

                else if (n2 > n3)
                {
                    Console.WriteLine("Largest number is " + n2);
                }
                else
                {
                    Console.WriteLine("Largest number is " + n3);
                }
            }
        }
    }

}