/*
 * Copyright 2025 yiroth
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Purpose: A structure for managing the time information
 */

using UnityEngine;

namespace LibYiroth.Data
{
    [System.Serializable]
    public struct Time
    {
        [SerializeField] private int hour;
        [SerializeField] private int minute;
        [SerializeField] private int second;

        public Time(int hour = 0, int minute = 0, int second = 0)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

	    public readonly int GetHours()
        { 
            return hour;
        }

	    public readonly int GetMinutes()
        { 
            return minute;
        }

	    public readonly int GetSeconds()
        { 
            return second;
        }

	    public void AddHours(int value = 1)
        { 
            hour += value;
        }

	    public void AddMinutes(int value = 1)
        { 
            minute += value;
        }

	    public void AddSeconds(int value = 1)
        { 
            second += value;
        }

	    public void SetHours(int value)
        { 
            hour = value;
        }

	    public void SetMinutes(int value) 
        { 
            minute = value;
        }

	    public void SetSeconds(int value)
        { 
            second = value;
        }

        public readonly int GetTotalSeconds()
        { 
            return (hour * 3600) + (minute * 60) + second; 
        }

        public static Time GetTimeFromSeconds(int totalSeconds)
        {
            totalSeconds = Mathf.Clamp(totalSeconds, 0, 86400);

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return new Time(hours, minutes, seconds);
        }        
    }
}
