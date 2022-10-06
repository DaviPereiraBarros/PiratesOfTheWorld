using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDeath : MonoBehaviour
{
    public static AnimationDeath instance;

    private void Awake()
    {
        instance = this;
    }

    public SpriteRenderer spriteAtual;
    public Sprite[] spriteAnimation;
    public GameObject objAnimation;
    
   
    
}
