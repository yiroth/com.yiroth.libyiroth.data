/* 
 *  Copyright © yiroth, all right reserved 
 *  Creation date: 2025-11-23
 *  Purpose: Struct to represent time in hours, minutes, and seconds
*/

namespace LibYiroth.Data
{
    public struct Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        public Time(int hour = 0, int minute = 0, int second = 0)
        {
            _hour = hour;
            _minute = minute;
            _second = second;
        }

	    public int GetHours()
        { 
            return _hour;
        }

	    public int GetMinutes()
        { 
            return _minute;
        }

	    public int GetSeconds()
        { 
            return _second;
        }

	    public void AddHours(int value = 1)
        { 
            _hour += value;
        }

	    public void AddMinutes(int value = 1)
        { 
            _minute += value;
        }

	    public void AddSeconds(int value = 1)
        { 
            _second += value;
        }

	    public void SetHours(int value)
        { 
            _hour = value;
        }

	    public void SetMinutes(int value) 
        { 
            _minute = value;
        }

	    public void SetSeconds(int value)
        { 
            _second = value;
        }

        public int GetTotalSeconds()
        { 
            return (_hour * 3600) + (_minute * 60) + _second; 
        }
    }
}
