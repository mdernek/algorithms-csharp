using Algorithms.Questions;
using Xunit;

namespace AlgorithmTests.Questions
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Fact]
        public void LongestSubstringWithoutRepeatingCharactersFound(){
            string str = "geeksforgeeks";

            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new();
            var result = longestSubstringWithoutRepeatingCharacters.GetLongestSubstringWithoutRepeatingCharactersCount(str);

            Assert.Equal(7, result);
        }

        [Fact]
        public void LongestSubstringWithoutRepeatingCharactersFound2(){
            string str = "dvdf";

            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new();
            var result = longestSubstringWithoutRepeatingCharacters.GetLongestSubstringWithoutRepeatingCharactersCount(str);

            Assert.Equal(3, result);
        }
    }
}
