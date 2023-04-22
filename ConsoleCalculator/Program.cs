namespace ConsoleCalculator
{
    internal class Program
    {
        static ILogger _logger { get; set; }
        static IUserInput _input { get; set; }

        static void Main(string[] args)
        {
            _logger = new MyLogger();
            _input = new UserInput(_logger);
            INumbersSum MySumNumbers = new NumbersSum(_logger);

            Console.WriteLine("Please insert thirst number to sum.");
            int num1 = _input.GetValidNum();
            Console.WriteLine("Please insert second number to sum.");
            int num2 = _input.GetValidNum();

            int result = MySumNumbers.GetSum(num1, num2);
            Console.WriteLine($"Sum is equals:");
            Console.WriteLine(result);
        }
    }
}