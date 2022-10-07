using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Generator : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float generatorRate;

    public float maxEnemy;

    
    void Start()
    {
        InvokeRepeating("GeneratorEnemy", generatorRate, generatorRate);
    }

    private void GeneratorEnemy()
    {
        GameObject enemyClone = Instantiate(enemyPrefab, transform.position, transform.rotation);  

        maxEnemy -= 1;
        if (maxEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }



    
}
