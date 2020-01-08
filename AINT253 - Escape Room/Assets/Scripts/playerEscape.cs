using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerEscape : MonoBehaviour
{
    public Animator FadeOut;
    public GameObject victoryButtons;
    public GameObject player;
    public GameObject inventoryUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        player.GetComponent<playerMovementScript>().enabled = false;

        Cursor.lockState = CursorLockMode.None;

        FadeOut.enabled = true;
        FadeOut.Play("FadeOut");
        inventoryUI.SetActive(false);

        StartCoroutine(loadButtons());

    }
    IEnumerator loadButtons()
    {
        yield return new WaitForSeconds(3.0f);
        Cursor.visible = true;
        victoryButtons.SetActive(true);
    }
}
