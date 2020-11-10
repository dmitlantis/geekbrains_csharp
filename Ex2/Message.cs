using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    static class Message
    {
        static public string noMoreThan(string s, int N)
        {
            string[] words = s.Split(' ');
            StringBuilder matchingWords = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length <= N)
                {
                    matchingWords.Append(word + ' ');
                }
            }
            return matchingWords.ToString();
        }

        static public string deleteEnding(string s, char c)
        {
            string[] words = s.Split(' ');
            StringBuilder matchingWords = new StringBuilder();
            foreach (string word in words)
            {
                if (word[word.Length - 1] != c)
                {
                    matchingWords.Append(word + ' ');
                }
            }
            return matchingWords.ToString();
        }

        static public string findLongestWords(string s)
        {
            string[] words = s.Split(' ');
            int maxLen = 0;
            StringBuilder matchingWords = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length > maxLen)
                {
                    maxLen = word.Length;
                }
            }
            foreach (string word in words)
            {
                if (word.Length == maxLen)
                {
                    matchingWords.Append(word + ' ');
                }
            }
            return matchingWords.ToString();
        }
    }
}
