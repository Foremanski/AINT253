using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioAmbient : MonoBehaviour
{
    public AudioSource ambientWind;
    public AudioSource ambientWater;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("PlayAudio");
    }

    IEnumerator PlayAudio()
    {
        bool sceneActive = true;
        
        while (sceneActive == true)
        {
            float random = Random.Range(10.0f, 100.0f);

            yield return new WaitForSeconds(random);
            ambientWind.Play();
        }
        
    }
}
