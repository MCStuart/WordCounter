using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace WordCount.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void CharacterEvaluator_IsEqualToItself_True()
        {
            // Arrange
            // Act
            CharacterEvaluator newChar = new CharacterEvaluator();
            // Assert
            Assert.AreEqual(typeof(CharacterEvaluator), newChar.GetType());
        }
    }
}
