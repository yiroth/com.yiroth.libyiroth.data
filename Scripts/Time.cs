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
 * Purpose: Structure to manage time information
 */

using UnityEngine;

namespace LibYiroth.Data
{
    [System.Serializable]
    public struct Time
    {
        [SerializeField] private int _hour;
        [SerializeField] private int _minute;
        [SerializeField] private int _second;

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
