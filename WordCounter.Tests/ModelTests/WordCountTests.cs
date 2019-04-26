using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            StringEval newStringEval = new StringEval("word", "This is a sentence.");
            // Act
            bool doesContain = newStringEval.IsStringInField();
            // Assert
            Assert.AreEqual(true, doesContain);
        }
    }
}
