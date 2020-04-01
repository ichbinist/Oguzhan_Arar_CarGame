using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
  public void LevelChange(){
    Application.LoadLevel(Application.loadedLevel+1);
  }
  public void LevelReset(){
    Application.LoadLevel(Application.loadedLevel);
  }
  public void ReturnMainMenu(){
   SceneManager.LoadScene("MainMenu");
  }
}
