using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace UnitySimpleLiquid
{
    public class OnClick : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
           

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetLiquid()
        {
            LiquidContainer liquid;
            GameObject liquidObject = GameObject.FindWithTag("BeakerPH");
            if (liquidObject != null)
            {
                liquid = liquidObject.GetComponent<LiquidContainer>();
                liquid.Reset();
            }
        }

        public void StartPractical()
        {
            SceneManager.LoadScene("Main");
        }

        public void ViewInfo()
        {
            SceneManager.LoadScene("Info");
        }

        public void ViewQA()
        {
            SceneManager.LoadScene("QuestionAnswer");
        }

    }
}
