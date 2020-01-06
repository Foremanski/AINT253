using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class stopPlayerMovement : MonoBehaviour
    {
        public bool stopPlayer = false;
        public GameObject Player;

        void Update()
        {
            if (stopPlayer == true)
            {
                gameObject.GetComponent<playerMovementScript>().enabled = false;
                gameObject.GetComponent<MouseLook>().lockCursor = false;
                Cursor.visible = enabled;
                Cursor.lockState = CursorLockMode.Confined;

            }

            else if(stopPlayer == false)
            {
                gameObject.GetComponent<playerMovementScript>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                gameObject.GetComponent<MouseLook>().lockCursor = true;
            }
        }
    }


