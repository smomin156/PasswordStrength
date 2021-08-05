using System;
using System.Runtime.Serialization;

namespace PasswordStrength
{
    class MinimumLengthException : Exception
    {
        public MinimumLengthException(string message) : base(message)
        {
        }

    }
}