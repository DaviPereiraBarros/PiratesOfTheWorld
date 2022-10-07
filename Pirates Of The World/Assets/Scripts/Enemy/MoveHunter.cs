using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHunter : MonoBehaviour
{
   public static MoveHunter hunter;

   private void Awake()
   {
        hunter = this;
   }
   

    public Transform target;
    private CircleCollider2D enemyCollider;
    public GameObject objAnim;
    public float speedEnemy;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

 
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speedEnemy * Time.deltaTime);
        transform.Translate(0, -speedEnemy * Time.deltaTime, 0);
        Detect();
    }

    void Detect()
    {
        transform.rotation = target.transform.rotation;

       if(GUI_Enemy.instanciaEnemy.lifeEnemy == 0)
       {
         transform.rotation = new Quaternion(0, 0, 0, 0);
       }
    }

}

    

