using UnityEngine;
using UnityEngine.UI;

namespace MobileTyping.Scripts
{
    public class SentenceViewer : MonoBehaviour
    {
        [SerializeField] private Text sampleText;
        private string targetSetence { get; set; }

        /*
         * 表示、変更、
         */
        private void Start()
        {
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                
            }
        }
    }
}