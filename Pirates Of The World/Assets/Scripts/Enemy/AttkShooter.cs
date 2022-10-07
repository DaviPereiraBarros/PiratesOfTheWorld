using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttkShooter : MonoBehaviour
{
    public static AttkShooter attkShooter;

    private void Awake()
    {
        attkShooter = this;
    }

    public Transform target;
    public Rigidbody2D bulletEnemy;
    public GameObject attkShooterObj;
    public float speedBullet;
    public float distance;
    public float speedShooter; 

    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void Follow()
    {
        distance = Vector2.Distance(transform.position, target.position);

        if(distance >= 3)
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
