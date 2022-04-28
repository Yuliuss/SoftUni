using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string exception)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exception);
            }
        }
        public static void ThrowIfNumberIsNegative(decimal number, string exception)
        {
            if (number < 0)
            {
                throw new ArgumentException(exception);
            }
        }

    }
}
