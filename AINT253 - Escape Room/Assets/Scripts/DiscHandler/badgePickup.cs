using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badgePickup : MonoBehaviour
{
    public GameObject badgeLight;
    public GameObject badgeImage;
    public GameObject activateGate;

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
        if(Input.GetKey("e"))
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            badgeLight.SetActive(false);
            badgeImage.SetActive(true);
            activateGate.GetComponent<activateGate>().gateActivated = true;
        }
    }
}
