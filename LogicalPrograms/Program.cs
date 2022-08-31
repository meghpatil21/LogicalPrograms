namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine();
            Console.WriteLine("Choose an Option from following:\n 1.Fibonacci Series\n 2.Perfect Number\n 3.Prime Number\n 4.Reverse Number\n 5.Coupon number");
            int option=Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            { 
                case 1:FinonacciSeries.FibSeries();
                    break;
                case 2: PerfectNumber.PerfectNo();
                    break;
                case 3: PrimeNumber.PrimeNo();
                    break;
                case 4: ReverseNumber.RevNo();
                    break;
                case 5: CouponNumbers.CoupnNo();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}