using System.Collections.Generic;

namespace Lesson_06_DU.App
{
    public static class StringExtensions
    {
        public static IEnumerable<string> SplitToWords(this string str)
        {
            return str.Split(new char[] { ' ', ',', '.' });
        }
    }
}
