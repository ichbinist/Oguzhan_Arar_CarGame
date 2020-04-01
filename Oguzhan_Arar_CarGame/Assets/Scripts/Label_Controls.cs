using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Label_Controls : MonoBehaviour
{
  public Text Time_Label;
  public Text Car_Label;
  public Text Scene_Label;
  public float timer = 10f;
  public GameObject MainController;
    void Start()
    {
      Scene scene = SceneManager.GetActiveScene();
      Scene_Label.text = scene.name;
    }


    void Update()
    {
      if(MainController.GetComponent<GameController>().isStarted == true){
        timer -= Time.deltaTime;
      }
      Car_Label.text = ":" + (GameController.currentCar+1).ToString();
      Time_Label.text = timer.ToString("F");

    }
}
