namespace ConsoleCalculator
{
    public interface ILogger
    {
        void Error(string message);
        void Event(string message);
    }
}