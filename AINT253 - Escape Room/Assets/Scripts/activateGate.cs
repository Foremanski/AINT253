using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateGate : MonoBehaviour
{
    public bool gateActivated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        if(gateActivated == true && Input.GetKey("e"))
        {
            gameObject.GetComponent<animPlayerInteract>().activateAnimation = true;
        }
    }
}
