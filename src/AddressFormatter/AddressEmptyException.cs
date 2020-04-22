using System;
using System.Collections.Generic;
using System.Text;

namespace AddressFormatter
{
    public class AddressEmptyException : Exception
    {
        public AddressEmptyException()
        {
        }

        public AddressEmptyException(string message)
        : base(message)
        {
        }

        public AddressEmptyException(string message, Exception inner)
            : base(message, inner)
        { 
        }
    }
}
