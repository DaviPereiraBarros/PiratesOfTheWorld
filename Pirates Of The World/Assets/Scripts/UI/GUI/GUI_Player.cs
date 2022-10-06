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
    public GameObject objAnimation;    
    public float currentLife;
    
    void Start()
    {

    }

    
    void Update()
    {
        Damage();
        Death(4);
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

    private void Death(float time)
    {
        if(currentLife == 0)
        {
           objAnimation.SetActive(true);
           time -= 0.2f;
        }
    }


}
