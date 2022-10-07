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
    public GameObject[] objAnimation; 
    public CapsuleCollider2D capsuleCollider;
    public float currentLife;
    public float time;
    
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
        if(currentLife <= 0)
        {
           objAnimation[0].SetActive(true);
           objAnimation[1].SetActive(true);
           objAnimation[2].SetActive(true);

           time -= 0.2f;

           MovePlayer.instancePlayer.speed = 0;

           if(time <= 0)
           {
             time = 0;

             objAnimation[0].SetActive(false);
             objAnimation[1].SetActive(false);
             objAnimation[2].SetActive(false);

             gameOver.SetActive(true);

             MovePlayer.instancePlayer.speed = 0;

             shipAtual.sprite = statusShip[3];

            capsuleCollider.isTrigger = true;
           }
        }        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("BulletEnemy"))
        {
            currentLife -= 10;
        }
    }


}
