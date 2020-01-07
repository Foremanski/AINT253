using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPlayerInteract : MonoBehaviour
{
    public Animator animatedObject;
    public string playAnimation;
    public bool activateAnimation = false;

    // Start is called before the first frame update
    void Start()
    {
        //animatedObject.GetComponent<Animator>();
    }


    void OnMouseOver()
    {
        
        if (activateAnimation == true)
        {
            Debug.Log("Yes???");
            animatedObject.Play(playAnimation);
        }

        
    }
}
