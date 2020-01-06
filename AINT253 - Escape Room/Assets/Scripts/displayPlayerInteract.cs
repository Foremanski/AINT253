using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class displayPlayerInteract : MonoBehaviour
 {
    public Canvas displayUI;
    public GameObject blur;
    public GameObject Player;
    public bool unlocked;

        // Start is called before the first frame update
    void Start()
    {
       blur.SetActive(false);
       displayUI.gameObject.SetActive(false);
    }

    void OnMouseOver()
    {
        if (Input.GetKey("e"))
        {
            blur.SetActive(true);
            displayUI.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Player.GetComponent<playerMovementScript>().enabled = false;
            Player.GetComponent<MouseLook>().lockCursor = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) || unlocked == true)
        {
            unlockCase();

        }
    }

    void unlockCase()
    {
        blur.SetActive(false);
        displayUI.gameObject.SetActive(false);
        Player.GetComponent<playerMovementScript>().enabled = true;
            
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Player.GetComponent<MouseLook>().lockCursor = true;
    }
 }