using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateGate : MonoBehaviour
{
    public bool gateActivated;
    public GameObject SovietBadge;
    public AudioSource VictoryMusic;
    public GameObject animBadge;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        animBadge.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        int counter = 0;

        if (gateActivated == true && Input.GetKey("e"))
        {
            

            animBadge.SetActive(true);
            animBadge.GetComponent<Animator>().Play("PlaceBadge");

            SovietBadge.SetActive(false);
            VictoryMusic.Play();

            gameObject.GetComponent<AudioSource>().Play();
                     
            StartCoroutine("activateMusic");
        }
    }

    IEnumerator activateMusic()
    {
        yield return new WaitForSeconds(3.0f);



        gameObject.GetComponent<animPlayerInteract>().activateAnimation = true;

        player.GetComponent<Rigidbody>().mass = 25;

        yield return new WaitForSeconds(3.0f);

        gameObject.GetComponent<AudioSource>().Stop();
    }
}
