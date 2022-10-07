using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShooter : MonoBehaviour
{
    public static MoveShooter shooter;

    private void Awake()
    {
        shooter = this;
    }

    public Transform target;
    public GameObject objAnim;
    public GameObject attkShooterObj;
    public Rigidbody2D bulletEnemy;
    public float speedBullet;
    public float distance;
    public float speedShooter;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

   
    void Update()
    {
        AttkShooter.attkShooter.Follow();
        Detect();
        transform.rotation = target.transform.rotation;
    }


    void Detect()
    {
        transform.rotation = target.transform.rotation;

       if(GUI_Enemy.instanciaEnemy.lifeEnemy == 0)
       {
         transform.rotation = new Quaternion(0, 0, 0, 0);
       }
    }

    public void Follow()
    {
        distance = Vector2.Distance(transform.position, target.position);

        if(distance > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speedShooter * Time.deltaTime);
        }
        else if(distance <= 5)
        {
           InvokeRepeating("BulletShooter", 2f, 10f); 
        }
    }

    public void BulletShooter()
    {
        Rigidbody2D bulletClone = Instantiate(bulletEnemy, attkShooterObj.transform.position, attkShooterObj.transform.rotation);
        bulletClone.velocity = attkShooterObj.transform.position * speedBullet * Time.deltaTime;   
    }


}
