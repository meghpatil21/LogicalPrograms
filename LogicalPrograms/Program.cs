namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine();
            Console.WriteLine("Choose an Option from following:\n 1.Fibonacci Series\n 2.Perfect Number");
            int option=Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            { 
                case 1:FinonacciSeries.FibSeries();
                    break;
                case 2: PerfectNumber.PerfectNo();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}