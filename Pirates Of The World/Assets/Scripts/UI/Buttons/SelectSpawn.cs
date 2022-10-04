using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectSpawn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{   
    public static SelectSpawn selectSpawnTime; 
    private void Awake()
    {
        selectSpawnTime = this;
    }

    public Image sessionSpawn;
    public bool isModeSpawn;

      public void OnPointerEnter(PointerEventData eventData)
    {
        sessionSpawn.color = new Color(242, 0, 255, 255);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        sessionSpawn.color = Color.black;
    }

    public void ModeSpawn()
    {
        isModeSpawn = true;
        SelectSession.selectTime.isModeSession = false;
    }

   
}

