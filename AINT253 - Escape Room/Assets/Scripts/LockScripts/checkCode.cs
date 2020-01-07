using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkCode : MonoBehaviour
{
    public Text codeInputText1;
    public Text codeInputText2;
    public Text codeInputText3;
    public Text codeInputText4;

    public GameObject activateGate;
    public GameObject inventoryManager;
    public GameObject displaycase;
    public GameObject blur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (codeInputText1.text == ("8") &&
            codeInputText2.text == ("1") &&
            codeInputText3.text == ("3") &&
            codeInputText4.text == ("6"))
        {
            // Debug.Log("YES!");
            activateGate.GetComponent<activateGate>().gateActivated = true;

            //play unlock sound and animation
            displaycase.GetComponent<AudioSource>().Play();
            displaycase.GetComponent<animPlayerInteract>().activateAnimation = true;

            displaycase.GetComponent<displayPlayerInteract>().unlocked = true;

            displaycase.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
