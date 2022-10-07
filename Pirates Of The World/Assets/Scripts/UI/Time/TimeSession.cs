using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSession : MonoBehaviour
{
    public Text textTime;
    public Text textFinish;
    public Text textShadowFinish;
    public GameObject panelFinish;
    public float time;
    public float timeMax;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Session();
    }

    private void Session()
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

            textFinish.text = "FINISH";

            textShadowFinish.text = "FINISH";

            panelFinish.SetActive(true);
        }

        /*if(time >= 0.6f)
        {
            textTime.text = time.ToString("1" + ":" + time);
        }*/
    }

   /* public IEnumerator SecondsAndMin(int minutes)
    {
        minutes += 1;
        textTime.text = time.ToString(minutes + ":" + time);

        yield return new WaitForSeconds(time);
    }*/
}
