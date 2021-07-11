using System.Collections.Generic;
using MobileTyping.Scripts;
using NUnit.Framework;

namespace Tests
{
    public class SentenceCollationTest
    {
        [Test]
        public void サンプル()
        {
            var generator = new QwertySentenceGenerator();
            var separatedLetterList = generator.ParseKanaSentence("じんそうぜんいふぁいぼわいぱーちゃぺあぺからきなみょーほんとすけ");
            var typingSentence = generator.ConstructTypingSentence(separatedLetterList);

            foreach (var letterRow in typingSentence)
            {
                foreach (var cellLetter in letterRow)
                {
                    TestContext.Write(cellLetter);
                    TestContext.Write(" ");
                }
                TestContext.WriteLine();
            }
        }
        
        [TestCase("abcdef")]
        public void 途中まで正しい文字を入力した場合にTypingStateがMatch(string inputSentence)
        {
            var targetSentence = new List<string> {"a", "b", "c", "d", "e", "f", "g"};
            var sentenceCollator = new SentenceCollator(targetSentence);
            foreach (var inputCharacter in inputSentence)
            {
                Assert.That(sentenceCollator.IsMatchCharacter(inputCharacter.ToString()),
                    Is.EqualTo(TypingState.Match));
            }
        }

        [TestCase("abcdefg")]
        public void 正しい文字を全て入力するとTypingStateがComplete(string inputSentence)
        {
            var targetSentence = new List<string> {"a", "b", "c", "d", "e", "f", "g"};
            var sentenceCollator = new SentenceCollator(targetSentence);
            var typingState = TypingState.UnMatch;
            foreach (var inputCharacter in inputSentence)
            {
                typingState = sentenceCollator.IsMatchCharacter(inputCharacter.ToString());
            }

            Assert.That(typingState, Is.EqualTo(TypingState.Complete));
        }

        [TestCase("b")]
        public void 正しくない文字を入力するとTypingStateがUnMatch(string inputSentence)
        {
            var targetSentence = new List<string> {"a", "b", "c", "d", "e", "f", "g"};
            var sentenceCollator = new SentenceCollator(targetSentence);
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence), Is.EqualTo(TypingState.UnMatch));
        }

        [TestCase("abcedeftg")]
        public void 正しい文字とそうでない文字を入力しながら最終的にタイピングに成功(string inputSentence)
        {
            var targetSentence = new List<string> {"a", "b", "c", "d", "e", "f", "g"};
            var sentenceCollator = new SentenceCollator(targetSentence);
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[0].ToString()), Is.EqualTo(TypingState.Match));
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[1].ToString()), Is.EqualTo(TypingState.Match));
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[2].ToString()), Is.EqualTo(TypingState.Match));
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[3].ToString()), Is.EqualTo(TypingState.UnMatch));
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[4].ToString()), Is.EqualTo(TypingState.Match));
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[5].ToString()), Is.EqualTo(TypingState.Match));
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[6].ToString()), Is.EqualTo(TypingState.Match));
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[7].ToString()), Is.EqualTo(TypingState.UnMatch));
            Assert.That(sentenceCollator.IsMatchCharacter(inputSentence[8].ToString()), Is.EqualTo(TypingState.Complete));
        }
    }
}