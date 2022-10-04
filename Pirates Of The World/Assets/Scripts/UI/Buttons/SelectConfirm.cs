using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectConfirm : MonoBehaviour
{
    public void Mode()
    {
       if(SelectSession.selectTime.isModeSession)
       {
          SceneManager.LoadSceneAsync("SessionTime");
       }
       else if(SelectSpawn.selectSpawnTime.isModeSpawn)
       {
          SceneManager.LoadSceneAsync("SessionSpawn");
       }
       
    }
}
