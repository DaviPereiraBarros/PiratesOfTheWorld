using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //MoveForward e Rotate
    [SerializeField] private Vector2 direction;
    [SerializeField] private Vector3 rotation;
    [SerializeField] private Rigidbody2D rbPlayer;
    public float speed;
     
    
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rbPlayer.MovePosition(rbPlayer.position + direction * speed * Time.deltaTime);
    }

   
    void Update()
    {
        InputPlayer();
        RotationPlayer();
    }

    void InputPlayer()
    {
        direction = Vector2.zero;

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        
    }

    void RotationPlayer()
    {
        rotation = Input.mousePosition / 100;

        Vector3 posInitial = rotation - new Vector3(9, 5, 0);

        if(posInitial.x > transform.position.x)
        {

        }
    }
}
