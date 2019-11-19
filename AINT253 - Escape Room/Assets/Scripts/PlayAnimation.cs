using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayAnimation : MonoBehaviour
{
    public Button Text;
    public AudioClip sound;
    public Animator ani;
    public Canvas yourcanvas;



    void Start()
    {
        ani.enabled = false;
        yourcanvas.enabled = true;
    }


    public void Press()

    {
        Text.enabled = true;
        AudioSource.PlayClipAtPoint(sound, transform.position);
        ani.enabled = true;

    }
}
