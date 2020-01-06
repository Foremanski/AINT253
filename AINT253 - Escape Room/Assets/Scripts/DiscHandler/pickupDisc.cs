using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupDisc : MonoBehaviour
{
    public GameObject InventoryHandler;

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
            gameObject.SetActive(false);
            InventoryHandler.GetComponent<inventoryManager>().hasDisc = true;
        }
    }
}
