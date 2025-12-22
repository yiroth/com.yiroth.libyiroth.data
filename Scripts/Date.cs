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
 * Purpose: Structure to manage date information
 */

namespace LibYiroth.Data
{
    [System.Serializable]
    public struct Date
    {
        [UnityEngine.SerializeField] private int _year;
        [UnityEngine.SerializeField] private int _month;
        [UnityEngine.SerializeField] private int _day;

        public Date(int year = 0, int month = 0, int day = 0)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public readonly int GetYears() => _year;
        public readonly int GetMonths() => _month;
        public readonly int GetDays() => _day;

        public void AddYears(int value = 1) => _year += value;
        public void AddMonths(int value = 1) => _month += value;
        public void AddDays(int value = 1) => _day += value;

        public void SetYears(int value) => _year = value;
        public void SetMonths(int value) => _month = value;
        public void SetDays(int value) => _day = value;
    }
}
