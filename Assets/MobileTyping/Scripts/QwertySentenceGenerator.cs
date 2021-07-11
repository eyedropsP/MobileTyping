using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MobileTyping.Scripts
{
    public class QwertySentenceGenerator
    {
        private string targetSentence;

        // 短い文章生成してくれるWebサービスから取ってきたりしたい
        private static readonly List<string> SentenceList = new List<string>
        {
            "こんにちは",
            "うちの愛犬",
            "わたしのなまえはサネヒョルジュです",
            "ジャルジャルに興味ある奴",
        };

        public void GetSentence()
        {
            var sentenceCount = SentenceList.Count;
            var randomValue = Random.Range(0, sentenceCount);
            targetSentence = SentenceList[randomValue];
        }

        public List<string> ParseKanaSentence(string targetStr)
        {
            var returnList = new List<string>();
            var index = 0;

            while (index < targetStr.Length)
            {
                var uni = targetStr[index].ToString();
                var bi = index + 1 < targetStr.Length ? targetStr.Substring(index, 2) : "";
                var tri = index + 2 < targetStr.Length ? targetStr.Substring(index, 3) : "";

                if (KeyMapConstants.KeyMap.ContainsKey(tri))
                {
                    index += 3;
                    returnList.Add(tri);
                }
                else if (KeyMapConstants.KeyMap.ContainsKey(bi))
                {
                    index += 2;
                    returnList.Add(bi);
                }
                else
                {
                    index++;
                    returnList.Add(uni);
                }
            }

            return returnList;
        }

        public IEnumerable<List<string>> ConstructTypingSentence(List<string> separatedLetterList)
        {
            var returnList = new List<List<string>>();
            var letterCounts = separatedLetterList.Count;
            for (var i = 0; i < letterCounts; ++i)
            {
                var pickedLetter = separatedLetterList[i];
                List<string> validTypeList;
                // 文「ん」の処理
                if (pickedLetter.Equals("ん") && (letterCounts - 1) == 1)
                {
                    var nList = new List<string>(KeyMapConstants.KeyMap[pickedLetter]);
                    nList.Remove("n");
                    validTypeList = nList;
                }
                else
                {
                    validTypeList = KeyMapConstants.KeyMap[pickedLetter].ToList();
                }

                returnList.Add(validTypeList);
            }

            return returnList;
        }

        public (string, string, List<string>, List<List<string>>) GenerateSentence(int g)
        {
            var list = new List<string>();
            var ty = new List<List<string>>();
            return ("", "", list, ty);
        }
    }
}