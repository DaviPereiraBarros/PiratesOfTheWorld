using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Player : MonoBehaviour
{
    public Image lifeImg;
    public Sprite[] statusShip;
    public SpriteRenderer shipAtual;
    public GameObject gameOver;
    public float currentLife;
    
    void Start()
    {

    }

    
    void Update()
    {
        Damage();
        Death();
        lifeImg.fillAmount = currentLife / 100;
    }

    private void Damage()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            currentLife -= 5;
        }

        if(currentLife == 60)
        {
           shipAtual.sprite = statusShip[1];
        }

        if(currentLife == 30)
        {
            shipAtual.sprite = statusShip[2];
        }
    }

    private void Death()
    {
        if(currentLife == 0)
        {
           gameOver.SetActive(true);
        }
    }
}
