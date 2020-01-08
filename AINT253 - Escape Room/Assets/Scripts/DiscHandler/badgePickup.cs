using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badgePickup : MonoBehaviour
{
    public GameObject badgeLight;
    public GameObject badgeImage;
    public GameObject activateGate;

    void Start()
    {
        badgeImage.SetActive(false);
    }

    public void pickUpBadge()
    {
            
            badgeLight.SetActive(false);
            badgeImage.SetActive(true);
            activateGate.GetComponent<activateGate>().gateActivated = true;

            gameObject.SetActive(false);
    }
}
