using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class UserInput : IUserInput
    {
        private ILogger _logger { get; set; }

        public UserInput(ILogger logger)
        {
            _logger = logger;
        }

        private bool IsItValidNum(string str, out int output)
        {
            output = 1;
            // output will be rewritten at least if the check is passed.
            _logger.Event($"Perfoming check if {str} in a int.");
            return ((str.Length > 0) && (int.TryParse(str, out output)));
        }

        public int GetValidNum()
        {
            string input;
            int output;

            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    _logger.Event($"Taken input in form of string: {input}");
                    if (IsItValidNum(input, out output))
                    {
                        _logger.Event($"{output} is a valid number!");
                        return output;
                    }
                    throw new FormatException("Format exception: please type correct number");
                }
                catch (FormatException ex)
                {
                    _logger.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    _logger.Error(ex.Message);
                }
            }

        }

    }
}
