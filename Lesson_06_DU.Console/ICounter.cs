using System.Collections.Generic;

namespace Lesson_06_DU.App
{
    public interface ICounter
    {
        Dictionary<string, int> GetWordsCount(string text);
        Dictionary<char, int> GetCharactersCount(string text);
        Dictionary<char, int> GetCharactersCount(string text, HashSet<char> characters);
    }
}
