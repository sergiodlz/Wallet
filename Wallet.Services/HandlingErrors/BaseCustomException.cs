using System;

namespace Wallet.Services.HandlingErrors
{
    public class BaseCustomException : Exception
    {
        public int Code { get; }

        public string Description { get; }

        public BaseCustomException(string message, string description, int code) : base(message)
        {
            Code = code;
            Description = description;
        }
    }
}