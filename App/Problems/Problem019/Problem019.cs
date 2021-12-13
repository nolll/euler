﻿using App.Platform;

namespace App.Problems.Problem019
{
    public class Problem019 : Problem
    {
        public override string Name => "Counting Sundays";

        public override ProblemResult Run()
        {
            var startDate = DateTime.Parse("1901-01-01");
            var endDate = DateTime.Parse("2000-12-31");
            var result = Run(startDate, endDate);
            return new ProblemResult(result, 171);
        }

        public int Run(DateTime startDate, DateTime endDate)
        {
            var firstSunday = startDate;
            while (firstSunday.DayOfWeek != DayOfWeek.Sunday)
            {
                firstSunday = firstSunday.AddDays(1);
            }

            var sundayCount = 0;
            var currentDate = firstSunday;
            while (currentDate < endDate)
            {
                if (currentDate.Day == 1)
                {
                    sundayCount++;
                }
                currentDate = currentDate.AddDays(7);
            }
            
            return sundayCount;
        }
    }
}