﻿using System.Collections;
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


    void Update()
    {
        
        if (activateAnimation == true)
        {
            animatedObject.Play(playAnimation);
        }

        
    }
}
