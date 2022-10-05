using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public void Update()
    {
       Destroy(gameObject, 4f);
    }
    
}
