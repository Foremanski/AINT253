using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class changeLockInt : MonoBehaviour
{
    public Text lockText;
    public int lockInt;

    // Start is called before the first frame update
    void Start()
    {
        lockText = GameObject.Find("txtCodeInput").GetComponent<Text>();
        lockInt = int.Parse(lockText.text);
       
    }

    private void IncreaseInt()
    {
        lockInt += 1;
        lockText.text = lockInt.ToString();
    }

    private void DecreaseInt()
    {

    }
}
