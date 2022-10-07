using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public static Coin coinInstance;

    private void Awake()
    {
        coinInstance = this;
    }

    public int coinTotal;
    public int coin;
    public Text textCoin;
    public Text textCoinTotal;


    
    void Start()
    { 
        coinTotal = PlayerPrefs.GetInt("coin");
    }

    
    public void UpdateCoin()
    {
       coin++;
       textCoin.text = coin.ToString();

       coinTotal++;

       PlayerPrefs.SetInt("coin", coinTotal);
    }
}
