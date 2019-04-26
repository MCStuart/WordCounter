using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace WordCount.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void CharEval_IsEqualToItself_True()
        {
            // Arrange
            // Act
            CharEval newCharEval = new CharEval('a');
            // Assert
            Assert.AreEqual(typeof(CharEval), newCharEval.GetType());
        }

        [TestMethod]
        public void CharEval_CanEvaulateCharMatch_True()
        {
            // Arrange
            CharEval newCharEval = new CharEval('b');
            // Act
            char result = newCharEval.GetLetter();
            // Assert
            Assert.AreEqual('b', result);
        }
    }
}
