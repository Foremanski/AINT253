using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFlicker : MonoBehaviour
{ 

    public GameObject flickerLight;

    // Start is called before the first frame update
    void Update()
    {
        StartCoroutine(flicker());
    }

    // Update is called once per frame
    IEnumerator flicker()
    {
        bool sceneactive = true;
        float waitTime = Random.Range(5.0f, 1000.0f);

        while (sceneactive == true)
        {
            
            flickerLight.SetActive(true);
            yield return new WaitForSeconds(waitTime);
            flickerLight.SetActive(false);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
