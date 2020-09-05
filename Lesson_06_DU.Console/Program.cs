using System;
using System.Collections.Generic;

namespace Lesson_06_DU.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // You can use this string as testing data.
            var text = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,";
            var characterSet = new HashSet<char> { 'i', 'k', 'r' };

            // Create a class Counter that implements ICounter interface.
            var counter = new Counter();

            Console.WriteLine();

            //=====================================================================================================================

            var wordsCount = counter.GetWordsCount(text);

            Console.WriteLine("Words count: ");
            foreach (var word in wordsCount)
            {
                Console.Write("{0} ", word.Key);
                Console.WriteLine(word.Value);
            }

            Console.WriteLine();

            //=====================================================================================================================

            var charactersCount = counter.GetCharactersCount(text);

            Console.WriteLine("Characters count: ");
            foreach (var character in charactersCount)
            {
                Console.Write("{0} ", character.Key);
                Console.WriteLine(character.Value);
            }

            Console.WriteLine();

            //=====================================================================================================================

            var charactersSetCount = counter.GetCharactersCount(text, characterSet);

            Console.WriteLine("Characters from HashSet Count: ");
            foreach (var character in charactersSetCount)
            {
                Console.Write("{0} ", character.Key);
                Console.WriteLine(character.Value);
            }

            Console.WriteLine();

            //=====================================================================================================================

            //=====================================================================================================================

            // Create a generic class Comparator<T> that implements IComparator<T> interface.
            var intEnumerableValues = new List<int> {5, 6, 7, 8, 4, 2, 7, 6, 9, 0, 2, 5, 7, 6, 3, 5, 5, 4, 2, 6, 3};
            var intCompare = 5;
            var intComparator = new Comparator<int>();

            var intGreaterThan = intComparator.GetGreaterThan(intCompare, intEnumerableValues);

            Console.WriteLine("Int values greater than {0}: ", intCompare);
            foreach (var number in intGreaterThan)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Int values greater or equal to {0}: ", intCompare);
            var intGreaterThanOrEqualTo = intComparator.GetGreaterThanOrEqualTo(intCompare, intEnumerableValues);

            foreach (var number in intGreaterThanOrEqualTo)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
            Console.WriteLine();

            //=====================================================================================================================

            var floatEnumerableValues = new List<float> { 3.5f, 0.6f, 5.5f, 8.1f, 4.5f, 5.2f, 1.7f, 6.5f, 9.3f, 0.9f, 4.2f, 6.5f, 8.7f, 1.6f, 1.3f, 8.5f, 7.5f, 2.4f, 1.2f, 7.6f, 8.1f };
            var floatCompare = 5.5f;
            var floatComparator = new Comparator<float>();

            var floatGreaterThan = floatComparator.GetGreaterThan(floatCompare, floatEnumerableValues);

            Console.WriteLine("Float values greater than {0}: ", floatCompare);
            foreach (var number in floatGreaterThan)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Float values greater or equal to {0}: ", floatCompare);
            var floatGreaterThanOrEqualTo = floatComparator.GetGreaterThanOrEqualTo(floatCompare, floatEnumerableValues);

            foreach (var number in floatGreaterThanOrEqualTo)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
            Console.WriteLine();

            //=====================================================================================================================

            var stringEnumerableValues = text.SplitToWords();
            var stringCompare = "sodales";
            var stringComparator = new Comparator<string>();

            var stringGreaterThan = stringComparator.GetGreaterThan(stringCompare, stringEnumerableValues);

            Console.WriteLine("String values greater than {0}: ", stringCompare);
            foreach (var number in stringGreaterThan)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("String values greater or equal to {0}: ", stringCompare);
            var stringGreaterThanOrEqualTo = stringComparator.GetGreaterThanOrEqualTo(stringCompare, stringEnumerableValues);

            foreach (var number in stringGreaterThanOrEqualTo)
            {
                Console.Write("{0} ",number);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
