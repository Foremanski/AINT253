using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeDisc : MonoBehaviour
{
    public GameObject Player;
    public GameObject Disc;
    public GameObject imageDisc;

    public Animator animatedObject;
    public string playAnimation;

    // Start is called before the first frame update
    void Start()
    {
        Disc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    private void OnMouseOver()
    {
        if(Input.GetKey("e") && Player.GetComponent<inventoryManager>().hasDisc == true)
        {
            //enable object 
            Disc.SetActive(true);
            imageDisc.SetActive(false);
            //play animation
            animatedObject.Play(playAnimation);
            
            //play audio
        }
    }
}
