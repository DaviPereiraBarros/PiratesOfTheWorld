using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Vector2 direction;
    [SerializeField] private Rigidbody2D rbPlayer;
    public float speed;
     
    
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }   
    void Update()
    {
        InputPlayer();
    }

    void InputPlayer()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -2.7f);

            if(transform.rotation.z == -180)
            {
                transform.rotation = new Quaternion(0, 0, -180, 0);
            }
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, 2.7f);

            if(transform.rotation.z == 180)
            {
                transform.rotation = new Quaternion(0, 0, 180, 0);
            }
        }
        
    }

}
