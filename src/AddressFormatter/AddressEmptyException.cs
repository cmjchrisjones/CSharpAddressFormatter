using System;

namespace CJTech.AddressFormatter
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
