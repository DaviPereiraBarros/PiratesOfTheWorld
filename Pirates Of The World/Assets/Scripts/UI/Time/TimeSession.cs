using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSession : MonoBehaviour
{
    public Text textTime;
    public float time;
    public float timeMax;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        MaxTime();
    }

    private void MaxTime()
    {
        time = time + Time.deltaTime / 100;

        textTime.text = time.ToString("F2");

        if(timeMax > 3)
        {
            timeMax = 3;
        }
        else if(timeMax < 1)
        {
            timeMax = 1;
        }

        if(time >= timeMax)
        {
            time = timeMax;
        }
    }
}
