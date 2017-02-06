using System;

namespace stringcalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (numbers.Contains(","))
            {
                return ExtractAndAdd(numbers);
            }
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            return int.Parse(numbers);
        }

        private int ExtractAndAdd(string numbers)
        {
            char[] separators = { ',' };
            string[] parts = numbers.Split(separators);
            return int.Parse(parts[0]) +
                    int.Parse(parts[1]);
        }

    }
}
