using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
    public void BttStart(string scene)
    {
       SceneManager.LoadSceneAsync(scene);
    }
}
