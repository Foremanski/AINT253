using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewScene : MonoBehaviour
{

    public string sceneName;

    public void StartGame()
    {
        Debug.Log("Yeetus");

        StartCoroutine("FadeOut");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.Log("Yeetus");
        SceneManager.LoadScene(sceneName);
    }
}
