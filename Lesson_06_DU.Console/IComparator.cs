using System.Collections.Generic;

namespace Lesson_06_DU.App
{
    public interface IComparator<T>
    {
        HashSet<T> GetGreaterThan(T compare, IEnumerable<T> values);
        HashSet<T> GetGreaterThanOrEqualTo(T compare, IEnumerable<T> values);
    }
}
