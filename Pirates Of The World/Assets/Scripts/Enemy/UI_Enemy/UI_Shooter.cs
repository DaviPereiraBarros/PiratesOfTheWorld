using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Shooter : MonoBehaviour
{
    public static UI_Shooter instanciaShooter;

    private void Awake()
    {
       instanciaShooter = this;
    }  


    public Image lifeEnemyImg;

    public Sprite[] shipState;

    public SpriteRenderer enemy;

     public GameObject objAnim;

    public float lifeEnemy; 

    void Start()
    {
        
    }

   
    void Update()
    {
        lifeEnemyImg.fillAmount = lifeEnemy / 100;
    }

    private void Damage()
    {
        if(lifeEnemy == 60)
        {
           enemy.sprite = shipState[1];
        }

        if(lifeEnemy == 30)
        {
            enemy.sprite = shipState[2];
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            lifeEnemy -= 20;

            if(lifeEnemy == 0)
            {
                Coin.coinInstance.UpdateCoin();
                objAnim.SetActive(true);

                transform.rotation = new Quaternion(0, 0, 0, 0);

                Destroy(gameObject, 1.2f);
            }
        }
    }
}
