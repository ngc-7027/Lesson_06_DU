using System;
using System.Collections.Generic;

namespace Lesson_06_DU.App
{
    public class Comparator<T> : IComparator<T> where T : IComparable
    {
        public HashSet<T> GetGreaterThan(T compare, IEnumerable<T> values)
        {
            HashSet<T> greaterThan = new HashSet<T>();

            foreach (var value in values)
            {
                if (value.CompareTo(compare) == 1)
                {
                    greaterThan.Add(value);
                }
            }

            return greaterThan;
        }

        public HashSet<T> GetGreaterThanOrEqualTo(T compare, IEnumerable<T> values)
        {
            HashSet<T> greaterThanOrEqualTo = new HashSet<T>();

            foreach (var value in values)
            {
                if (value.CompareTo(compare) >= 0)
                {
                    greaterThanOrEqualTo.Add(value);
                }
            }

            return greaterThanOrEqualTo;
        }
    }
}
