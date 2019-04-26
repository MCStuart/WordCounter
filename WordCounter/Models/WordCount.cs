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
            StringEval newStringEval = new StringEval("word", "This is a sentence with a word in it.");
            if (newStringEval.GetSentence().Contains(newStringEval.GetWord()) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
