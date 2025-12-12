/* 
 *  Copyright © yiroth, all right reserved 
 *  Creation date: 2025-11-23
 *  Purpose: Definition of a date structure
*/

namespace LibYiroth.Data
{
    public struct Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year = 0, int month = 0, int day = 0)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public int GetYears() => _year;
        public int GetMonths() => _month;
        public int GetDays() => _day;

        public void AddYears(int value = 1) => _year += value;
        public void AddMonths(int value = 1) => _month += value;
        public void AddDays(int value = 1) => _day += value;

        public void SetYears(int value) => _year = value;
        public void SetMonths(int value) => _month = value;
        public void SetDays(int value) => _day = value;
    }
}
