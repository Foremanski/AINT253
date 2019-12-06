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
        lockInt = int.Parse(lockText.text);
    }

    public void IncreaseInt()
    {
        if(lockInt != 9)
        {
            lockInt += 1;
            lockText.text = lockInt.ToString();
        }
        
    }

    public void DecreaseInt()
    {
        if(lockInt != 0)
        {
            lockInt -= 1;
            lockText.text = lockInt.ToString();
        }       
    }
}
