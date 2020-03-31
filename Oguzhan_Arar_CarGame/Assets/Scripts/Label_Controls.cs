using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Label_Controls : MonoBehaviour
{
  public Text Time_Label;
  public Text Car_Label;
  public Text Scene_Label;
  public float timer = 10f;
  public GameObject MainController;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(MainController.GetComponent<GameController>().isStarted == true){
        timer -= Time.deltaTime;
      }
      Car_Label.text = ":" + (GameController.currentCar+1).ToString();
      Time_Label.text = timer.ToString("F");
    }
}
