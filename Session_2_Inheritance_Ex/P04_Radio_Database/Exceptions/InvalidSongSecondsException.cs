﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Radio_Database.Exceptions
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException(string message = "Song seconds should be between 0 and 59.") : base(message)
        {

        }
    }
}
