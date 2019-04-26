using System.Collections.Generic;

namespace WordCount
{
    public class StringEval
    {
        private string _word;
        private string _sentence;

        public StringEval(string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }

        public string GetWord()
        {
            return _word;
        }

        public string GetSentence()
        {
            return _sentence;
        }

        public bool IsStringInField()
        {
            string word = this.GetWord();
            string sentence = this.GetSentence();
            if (this.GetSentence().Contains(this.GetWord()) == true)
            {
                return true;
            }
            return false;
        }

        public int RepeatCounter()
        {
            int wordCount = 0;
            string theWord = this.GetWord();
            string sentence = this.GetSentence();
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
