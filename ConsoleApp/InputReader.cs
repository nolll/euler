﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public static class InputReader
    {
        public static IList<string> ReadLines(string str)
        {
            return str.Trim().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
        }
    }
}