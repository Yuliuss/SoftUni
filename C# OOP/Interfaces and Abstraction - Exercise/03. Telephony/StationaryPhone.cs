using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : Phone
    {
        public override string Call(string number)
        {
            Validator.ThrowIfNumIsInvalid(number);

            return $"Dialing... {number}";
        }
    }
}
