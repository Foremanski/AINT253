using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Animator animatedObject;

    // Start is called before the first frame update
    void Start()
    {
        animatedObject.GetComponent<Animator>();
    }


    void Update()
    {
        if(Input.GetKeyDown("E"))
        {
            animatedObject.Play("GateOpen");
        }
    }
}
