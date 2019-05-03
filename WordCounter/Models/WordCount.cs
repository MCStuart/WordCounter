using System.Collections.Generic;
using System;

namespace WordCount.Models
{
    public class StringEval
    {
        private string _word;
        private string _sentence;

        public string Word { get => _word; set => _word = value; }
        public string Sentence { get => _sentence; set => _sentence = value; }

        public StringEval(string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }

        public bool IsStringInField()
        {
            string word = this.Word;
            string sentence = this.Sentence;
            if (this.Sentence.Contains(this.Word) == true)
            {
                return true;
            }
            return false;
        }

        public string StringCleaner()
        {

            string returnString = "";
            char[] sentenceArray = _sentence.ToCharArray();
            foreach(Char ch in sentenceArray)
            {
                if(Char.IsLetter(ch) || Char.IsWhiteSpace(ch))
                {
                    returnString += ch.ToString();
                }
            }
            this.Sentence = returnString;
            return Sentence;
        }

        public int RepeatCounter()
        {
            int wordCount = 0;
            string theWord = this.Word;
            string sentence = this.Sentence;
            string[] sentenceArray = sentence.Split(' ');
            foreach (string word in sentenceArray)
            {
                if (theWord == word)
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
    }
}
