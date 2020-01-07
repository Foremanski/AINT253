using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFootsteps : MonoBehaviour
{
    public GameObject footsteps;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Rigidbody>().velocity.magnitude > 0.5f)
        {
            if (footsteps.GetComponent<AudioSource>().isPlaying == false)
            {
                footsteps.GetComponent<AudioSource>().Play();
            }
                
        }

        if(gameObject.GetComponent<Rigidbody>().velocity.magnitude < 0.5f)
        {
            footsteps.GetComponent<AudioSource>().Stop();
        }
    }
}
