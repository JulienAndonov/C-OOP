﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Radio_Database.Exceptions
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException(string message = "Song minutes should be between 0 and 14.") : base(message)
        {

        }
    }
}
