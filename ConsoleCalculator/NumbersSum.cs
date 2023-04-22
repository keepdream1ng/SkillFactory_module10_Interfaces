using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class NumbersSum : INumbersSum
    {
        private ILogger _logger { get; set; }

        public NumbersSum(ILogger logger)
        {
            _logger = logger;
        }

        public int GetSum(int a, int b)
        {
            _logger.Event($"Calculating sum of numbers {a} and {b}.");
            return a + b;
        }
    }
}
