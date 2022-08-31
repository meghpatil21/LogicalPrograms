namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine();
            Console.WriteLine("Choose an Option from following:\n 1.Fibonacci Series");
            int option=Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            { 
                case 1:FinonacciSeries.FibSeries();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}