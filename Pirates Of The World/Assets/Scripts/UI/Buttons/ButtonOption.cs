using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour
{
   public GameObject mainMenu;
   public GameObject optionsMenu;

   public void BttOption()
   {
      mainMenu.SetActive(false);
      optionsMenu.SetActive(true);
   }
}
