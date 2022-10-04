using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectSession : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{   
    public static SelectSession selectTime; 
    private void Awake()
    {
        selectTime = this;
    }

    public Image sessionTime;
    public bool isModeSession;

      public void OnPointerEnter(PointerEventData eventData)
    {
        sessionTime.color = new Color(242, 0, 255, 255);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        sessionTime.color = Color.black;
    }

    public void ModeSession()
    {
        isModeSession = true;
        SelectSpawn.selectSpawnTime.isModeSpawn = false;
    }

   
}

