using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class stopPlayerMovement : MonoBehaviour
    {
        public GameObject Player;

        void OnMouseOver()
        {
            if (Input.GetKey("e"))
            {
                Player.GetComponent<playerMovementScript>().enabled = false;
                Player.GetComponent<MouseLook>().lockCursor = false;
                Cursor.visible = enabled;
                Cursor.lockState = CursorLockMode.Confined;
            }

            if(Input.GetKey(KeyCode.Escape))
            {
                Player.GetComponent<playerMovementScript>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Player.GetComponent<MouseLook>().lockCursor = true;
            }
        }
    }
}

