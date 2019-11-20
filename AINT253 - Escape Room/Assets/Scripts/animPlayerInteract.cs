using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPlayerInteract : MonoBehaviour
{
    public Animator animatedObject;
    public string playAnimation;

    // Start is called before the first frame update
    void Start()
    {
        animatedObject.GetComponent<Animator>();
    }


    void OnMouseOver()
    {

        if(Input.GetKeyDown("e"))
        {
            animatedObject.Play(playAnimation);
        }
    }
}
