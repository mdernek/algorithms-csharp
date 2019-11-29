using Xunit;
using System.Collections.Generic;
using Algorithms.DataStructure;

namespace AlgorithmTests.DataStructure
{
    public class TrieTest
    {
        [Fact]
        public void InsertTrie(){
            string[] keys = new string[] {"there", "the", "may", "maybe", "them", "their"};
            Trie trie = new Trie();

            foreach(string key in keys){
                trie.Insert(key);
            }

            Assert.Equal(6, trie.Count);
        }
        
        [Fact]
        public void SearchTrie(){
            string[] keys = new string[] {"there", "the", "may", "maybe", "them", "their"};
            string[] notInKeys = new string[] {"and", "ther", "th", "thei"};
            Trie trie = new Trie();

            foreach(string key in keys){
                trie.Insert(key);
            }

            foreach(string key in keys){
                Assert.True(trie.Search(key));
            }

            foreach(string key in notInKeys){
                Assert.False(trie.Search(key));
            }
        }

        [Fact]
        public void SearchEmptyTrie(){
            string[] keys = new string[] {"there"};
            Trie trie = new Trie();

            foreach(string key in keys){
                Assert.False(trie.Search(key));
            }
        }

        [Fact]
        public void DeleteTrie(){
            string[] keys = new string[] {"there", "the", "may", "maybe", "them", "their"};
            Trie trie = new Trie();

            foreach(string key in keys){
                trie.Insert(key);
            }

            trie.Delete("maybe");
            Assert.False(trie.Search("maybe"));
            Assert.True(trie.Search("may"));
        }

        [Fact]
        public void SuggestTrie(){
            string[] keys = new string[] {"there", "the", "may", "maybe", "them", "their", "than"};
            string[] suggestions = new string[] {"than", "the", "their", "them", "there"};
            string searchKey = "th";
            Trie trie = new Trie();

            foreach(string key in keys){
                trie.Insert(key);
            }

            int i=0;
            foreach(string suggestion in trie.Suggest(searchKey)){
                Assert.Equal(suggestions[i], suggestion);
                i++;
            }

            Assert.Equal(suggestions.Length, i);
        }

        [Fact]
        public void SuggestWithRealWordTrie(){
            string[] keys = new string[] {"there", "the", "may", "maybe", "them", "their", "than"};
            string[] suggestions = new string[] {"the", "their", "them", "there"};
            string searchKey = "the";
            Trie trie = new Trie();

            foreach(string key in keys){
                trie.Insert(key);
            }

            int i=0;
            foreach(string suggestion in trie.Suggest(searchKey)){
                Assert.Equal(suggestions[i], suggestion);
                i++;
            }

            Assert.Equal(suggestions.Length, i);
        }
    }
}