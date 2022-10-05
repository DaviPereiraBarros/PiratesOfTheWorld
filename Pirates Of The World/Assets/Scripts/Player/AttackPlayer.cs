using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public CursorMode cursor = CursorMode.Auto;
    public Texture2D cursorTexture;
    public Rigidbody2D bullet;
    public GameObject attkUlt;
    public Vector2 hotSpot = Vector2.zero;
    public Vector2 directionAim;
    public Vector3 posCursor;
    public float speedBullet;


    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursor);
        
    }

    void Update()
    {
        AimPlayer();
        ShootPlayer();
    }

    private void AimPlayer()
    {
        posCursor = Input.mousePosition / 100;

        directionAim = new Vector2(posCursor.x - 9.3f, posCursor.y - 5.8f);
    }

    private void ShootPlayer()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Bullet(); 
        }

        if(Input.GetKey(KeyCode.Space))
        {
            TrippleBullet();
        }
    }

    private void Bullet()
    {
        Rigidbody2D bulletClone = Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = directionAim * speedBullet * Time.deltaTime;   
    }

    private void TrippleBullet()
    {
       Rigidbody2D bulletClone = Instantiate(bullet, attkUlt.transform.position, transform.rotation);
       bulletClone.velocity = transform.position * speedBullet * Time.deltaTime;
       
    }

}
