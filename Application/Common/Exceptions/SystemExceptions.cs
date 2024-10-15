﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(string[] errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }

        public string[] Errors { get; set; }
    }
    public class NoDataFoundException : Exception
    {
        public NoDataFoundException(string message) : base(message)
        {
        }
    }
    public class SocketException : Exception
    {
        public SocketException(string message) : base(message)
        {
        }
    }
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException() : base("User already exists.")
        {
        }
    }
}
