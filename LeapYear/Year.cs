using System;

namespace LeapYear
{
    public class Year
    {
        private readonly int _year;

        public Year(int year)
        {
            _year = year;
        }

        public bool IsLeap()
        {
            return IsDivisibleBy(100) ? IsDivisibleBy(400) : IsDivisibleBy(4);
        }

        private bool IsDivisibleBy(int value)
        {
            return _year%value == 0;
        }
    }
}
