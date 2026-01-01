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
 * Purpose: A structure for managing the date information
 */

using UnityEngine;

namespace LibYiroth.Data
{
    [System.Serializable]
    public struct Date
    {
        [SerializeField] private int year;
        [SerializeField] private int month;
        [SerializeField] private int day;

        public Date(int year = 0, int month = 0, int day = 0)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public readonly int GetYears() => year;
        public readonly int GetMonths() => month;
        public readonly int GetDays() => day;

        public void AddYears(int value = 1) => year += value;
        public void AddMonths(int value = 1) => month += value;
        public void AddDays(int value = 1) => day += value;

        public void SetYears(int value) => year = value;
        public void SetMonths(int value) => month = value;
        public void SetDays(int value) => day = value;
    }
}
