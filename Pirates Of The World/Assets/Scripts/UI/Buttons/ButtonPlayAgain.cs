using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlayAgain : MonoBehaviour
{
    public void Reset(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

