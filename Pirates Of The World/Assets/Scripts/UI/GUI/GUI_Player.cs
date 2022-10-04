using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Player : MonoBehaviour
{
    public Image lifeImg;
    public float currentLife;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Damage();
        lifeImg.fillAmount = currentLife / 100;
    }

    private void Damage()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            currentLife -= 10;
        }
    }
}
