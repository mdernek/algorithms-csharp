using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Questions
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        private const int NO_OF_CHARS = 256;

        public LongestSubstringWithoutRepeatingCharacters()
        {
        }

        public int GetLongestSubstringWithoutRepeatingCharactersCount(string str){
            int[] lastIndex = new int[NO_OF_CHARS];
            Array.Fill(lastIndex, -1);
            int result = 0;
            int index = 0;

            for (int j = 0; j < str.Length; j++)
            {
                var chrNumber = str[j];
                var lastChrNumberIndex = lastIndex[chrNumber];
                index = Math.Max(index, lastChrNumberIndex + 1);
                result = Math.Max(result, j - index + 1);
                lastIndex[chrNumber] = j;
            }

            return result;
        }
    }
}
