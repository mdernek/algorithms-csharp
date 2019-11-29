//https://www.geeksforgeeks.org/trie-insert-and-search/
//https://www.geeksforgeeks.org/auto-complete-feature-using-trie/
using System.Collections.Generic;

namespace Algorithms.DataStructure
{
    public partial class Trie
    {
        TrieNode _root;
        public int Count { get; private set; }

        public Trie(){
            _root = new TrieNode();
        }

        public void Insert(string key){
            TrieNode node = _root;

            foreach(char k in key){
                int index = k - 'a';
                if(node.children[index] is null){
                    node.children[index] = new TrieNode();
                }

                node = node.children[index];
            }

            node.isEndOfWord = true;
            Count++;
        }

        public bool Search(string key){
            TrieNode node = _root;

            foreach(char k in key){
                int index = k - 'a';
                if(node.children[index] is null){
                    return false;
                }

                node = node.children[index];
            }

            return node != null && node.isEndOfWord;
        }

        public void Delete(string key){
            _root = DeleteNode(_root, key, 0);
        }

        private TrieNode DeleteNode(TrieNode node, string key, int depth){
            if(node is null){
                return null;
            }

            if(key.Length == depth){
                if(node.isEndOfWord){
                    node.isEndOfWord = false;
                }

                if(isEmpty(node)){
                    node = null;
                }

                return node;
            }

            int index = key[depth] - 'a';
            node.children[index] = DeleteNode(node.children[index], key, depth + 1);

            if(isEmpty(node) && node.isEndOfWord == false){
                node = null;
            }

            return node;
        }

        private bool isEmpty(TrieNode node){
            for(int i=0; i<ALPHABET_SIZE; i++){
                if(node.children[i] != null){
                    return false;
                }
            }

            return true;
        }

        public IEnumerable<string> Suggest(string key){
            if(string.IsNullOrEmpty(key)){
                yield break;
            }

            TrieNode node = _root;

            foreach(char k in key){
                int index = k - 'a';
                if(node.children[index] is null){
                    yield break;
                }

                node = node.children[index];
            }

            if(isEmpty(node)){
                yield break;
            }

            foreach(string suggession in SuggestNode(node, key)){
                yield return suggession;
            }
        }

        private IEnumerable<string> SuggestNode(TrieNode node, string prefix){
            if(node.isEndOfWord){
                yield return prefix;
            }

            for(int i=0; i<ALPHABET_SIZE; i++){
                if(node.children[i] != null){
                    char c = (char)(i + 'a');
                    foreach(string suggession in SuggestNode(node.children[i], prefix+c)){
                        yield return suggession;
                    }
                }
            }
        }
    }

    public partial class Trie
    {
        const int ALPHABET_SIZE = 26;

        class TrieNode 
        {
            public TrieNode[] children;
            public bool isEndOfWord;

            public TrieNode()
            {
                children = new TrieNode[ALPHABET_SIZE];
                isEndOfWord = false;

                for(int i=0; i<ALPHABET_SIZE; i++){
                    children[i] = null;
                }
            }
        }
    }
}