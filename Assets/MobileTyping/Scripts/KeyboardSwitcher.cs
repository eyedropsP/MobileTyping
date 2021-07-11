using UnityEngine;
using UnityEngine.UI;

namespace MobileTyping.Scripts
{
    public class KeyboardSwitcher : MonoBehaviour
    {
        [SerializeField] private Text _debugText;
        [SerializeField] private Button _defaultButton;
        [SerializeField] private Button _asciiCapableButton;
        [SerializeField] private Button _numberAndPunctuationButton;
        [SerializeField] private Button _urlButton;
        [SerializeField] private Button _numberPadButton;
        [SerializeField] private Button _phonePadButton;
        [SerializeField] private Button _namePhoneButton;
        [SerializeField] private Button _emailAddressButton;

        private void Start()
        {
            TouchScreenKeyboard.hideInput = true;
            
            _defaultButton.onClick.AddListener(() =>
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
                _debugText.text = "Defaultのキーボードを呼び出したよ";
            });

            _asciiCapableButton.onClick.AddListener(() =>
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.ASCIICapable);
                _debugText.text = "ASCIICapableのキーボードを呼び出したよ";
            });

            _numberAndPunctuationButton.onClick.AddListener(() =>
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NumbersAndPunctuation);
                _debugText.text = "NumbersAndPunctuationのキーボードを呼び出したよ";
            });

            _urlButton.onClick.AddListener(() =>
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.URL);
                _debugText.text = "URLのキーボードを呼び出したよ";
            });

            _numberPadButton.onClick.AddListener(() =>
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NumberPad);
                _debugText.text = "NumberPadのキーボードを呼び出したよ";
            });

            _phonePadButton.onClick.AddListener(() =>
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.PhonePad);
                _debugText.text = "PhonePadのキーボードを呼び出したよ";
            });

            _namePhoneButton.onClick.AddListener(() =>
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NamePhonePad);
                _debugText.text = "NamePhonePadのキーボードを呼び出したよ";
            });

            _emailAddressButton.onClick.AddListener(() =>
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.EmailAddress);
                _debugText.text = "EmailAddressのキーボードを呼び出したよ";
            });
        }
    }
}