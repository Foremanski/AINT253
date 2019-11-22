using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayPlayerInteract : MonoBehaviour
{
    public Canvas displayUI;

    // Start is called before the first frame update
    void Start()
    {
        displayUI.gameObject.SetActive(false);
    }

    void OnMouseOver()
    {
        if(Input.GetKey("e"))
        {
            displayUI.gameObject.SetActive(true);
            Cursor.visible = true;
            
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            displayUI.gameObject.SetActive(false);
            Cursor.visible = false;
        }

    }
}
