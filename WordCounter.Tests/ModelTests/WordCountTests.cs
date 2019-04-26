using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using WordCount;

namespace WordCount.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void StringEval_IsEqualToItself_True()
        {
            // Arrange
            // Act
            StringEval newStringEval = new StringEval("word", "");
            // Assert
            Assert.AreEqual(typeof(StringEval), newStringEval.GetType());
        }

        [TestMethod]
        public void StringEval_CanEvaulateStringMatch_True()
        {
            // Arrange
            StringEval newStringEval = new StringEval("word", "");
            // Act
            string result = newStringEval.GetWord();
            // Assert
            Assert.AreEqual("word", result);
        }

        [TestMethod]
        public void IsStringInField_CanEvaulateStringMatchInField_True()
        {
            // Arrange
            StringEval newStringEval = new StringEval("word", "there is a word in here");
            // Act
            bool doesContain = newStringEval.IsStringInField();
            // Assert
            Assert.AreEqual(true, doesContain);
        }

        [TestMethod]
        public void ToStringList_TurnsSentenceIntoArray_List()
        {
            // Arrange
            StringEval newStringEval = new StringEval("", "there is word in here");
            // Act
            List<string> testList = new List<string> { "there", "is", "a", "word", "in", "here" };
            List<string> wordsOfSentence = new List<string>(sentence.Split(' '));
            // Assert
            Assert.AreEqual(testList, wordsOfSentence);
        }
    }
}
