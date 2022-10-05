using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlayAgain : MonoBehaviour
{
    public GameObject player;
    public Text txtCoin;
    public Text txtTime;
    public GameObject gameOver;
    public Vector2 posInicialPlayer = Vector2.zero;

    public void PlayAgain()
    {
       player.transform.position = posInicialPlayer;

       txtCoin.text = "0";

       txtTime.text = "0:00";

       gameOver.SetActive(false);
    }
}
