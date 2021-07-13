using MobileTyping.Scripts;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class InputTest
    {
        [TestCase("あ")]
        [TestCase("い")]
        [TestCase("う")]
        [TestCase("え")]
        [TestCase("お")]
        public void 入力した文字がかな(string inputChar)
        {
            Assert.That(InputManager.IsKana(inputChar), Is.True);
        }
    }
}