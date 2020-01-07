using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{
    public Animator animatedObject;
    public string animationPlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playFadeAnimation()
    {
        animatedObject.enabled = true;
        animatedObject.Play(animationPlay);
    }
}
