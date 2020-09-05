using System.Collections.Generic;
using System.Linq;

namespace Lesson_06_DU.App
{
    public class Counter : ICounter
    {
        public Dictionary<string, int> GetWordsCount(string text)
        {
            var wordsCount = from w in text.SplitToWords()
                             orderby w
                             group w by w into grp
                             select new { word = grp.Key, count = grp.Count() };

            return wordsCount.ToDictionary(w => w.word, w => w.count);
        }

        public Dictionary<char, int> GetCharactersCount(string text)
        {
            var charactersCount = from c in text
                                  orderby c
                                  group c by c into grp
                                  select new {character = grp.Key, count = grp.Count()};

            return charactersCount.ToDictionary(c => c.character, c => c.count);
        }

        public Dictionary<char, int> GetCharactersCount(string text, HashSet<char> characters)
        {
            var charactersCount = from c in text 
                                  where characters.Contains(c)
                                  orderby c
                                  group c by c into grp
                                  select new { character = grp.Key, count = grp.Count() };

            return charactersCount.ToDictionary(c => c.character, c => c.count);
        }
    }
}
