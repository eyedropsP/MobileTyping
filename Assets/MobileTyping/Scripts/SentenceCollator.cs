using System.Collections.Generic;

namespace MobileTyping.Scripts
{
    public class SentenceCollator
    {
        public SentenceCollator(List<string> targetSentence)
        {
            _targetSentence = targetSentence;
            _remainingCharacterCount = _targetSentence.Count;
        }

        private readonly List<string> _targetSentence;
        private int _remainingCharacterCount;

        public TypingState IsMatchCharacter(string inputCharacter)
        {
            var index = _targetSentence.Count - _remainingCharacterCount;
            if (!string.Equals(_targetSentence[index], inputCharacter)) return TypingState.UnMatch;
            _remainingCharacterCount--;

            return _remainingCharacterCount == 0 ? TypingState.Complete : TypingState.Match;
        }
    }
}