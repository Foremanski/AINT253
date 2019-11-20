using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayOnMouseHover : MonoBehaviour
{
    // Start is called before the first frame update

    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    void Start()
    {
        myText = GameObject.Find("Text").GetComponent<Text>();


        myText.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        FadeText();        
    }
    void OnMouseOver()
    { 
        displayInfo = true;
    }

    void OnMouseExit()
    {
        displayInfo = false;
    }

    void FadeText()
    {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);
        }

        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
 