﻿namespace App.Platform
{
    public class TimeoutPuzzleResult : PuzzleResult
    {
        public TimeoutPuzzleResult(string message)
            : base(message, PuzzleResultStatus.Timeout)
        {
        }
    }
}