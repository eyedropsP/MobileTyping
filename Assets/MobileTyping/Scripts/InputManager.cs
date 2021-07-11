using System;
using UnityEngine;

namespace MobileTyping.Scripts
{
    public class InputManager : MonoBehaviour
    {
        private QwertySentenceGenerator _qwertySentenceGenerator;
        private SentenceCollator _sentenceCollator;

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
        }

        private void Update()
        {
            if (!Input.anyKeyDown) return;

            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    // Debug.Log(keyCode.ToString());
                }
            }
        }
    }
}