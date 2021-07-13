using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace MobileTyping.Scripts
{
    public class InputManager : MonoBehaviour
    {
        private QwertySentenceGenerator _qwertySentenceGenerator;
        private SentenceCollator _sentenceCollator;
        private TouchScreenKeyboard _keyboard;
        [SerializeField] private Text _isKanaText;
        [SerializeField] private Text _inputText;

        /*
         ここでセンテンスの生成すると責務的に違いすぎる気がする
         別のViewでしょうに
         キー入力Viewとセンテンス生成Viewがあるといい
         キー入力とセンテンス生成をEntryPointで操作になっちゃう
         結局設計かよ
         ReactiveProperty使わずに値同期やりたい
         それPropertyChangedでは
         */

        private void Start()
        {
            _keyboard = TouchScreenKeyboard.Open("");
            TouchScreenKeyboard.hideInput = true;
        }

        private void OnGUI()
        {
            var inputText = _keyboard.text;
            _isKanaText.text = IsKana(inputText) ? "ひらがな" : "それ以外";
            _inputText.text = inputText;
        }

        public static bool IsKana(string inputKana)
        {
            return Regex.IsMatch(inputKana, @"^\p{IsHiragana}*$");
        }
    }
}