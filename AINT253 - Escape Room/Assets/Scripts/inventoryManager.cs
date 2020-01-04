using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{

    private bool hasDisc = false;
    public Image imageDisc;

    private bool hasBadge = false;
    private bool hasPower = false;
    public Canvas InventoryUI;

    // Start is called before the first frame update
    void Start()
    {
        hasDisc = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(hasDisc == true)
        {
            imageDisc.enabled = true;
        }
        if(hasDisc == false)
        {
            imageDisc.enabled = false;
        }
    }
}
