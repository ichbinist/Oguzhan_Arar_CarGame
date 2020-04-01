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
  public Button btn_right;
  public Button btn_left;
  public Button restart;
  public Button next;
  public float timer = 10f;


  public GameObject MainController;
    void Start()
    {

    }

    void resize_btn(){
      btn_right.image.rectTransform.sizeDelta = new Vector2(Screen.height*0.25f, Screen.height*0.25f);
      btn_left.image.rectTransform.sizeDelta = new Vector2(Screen.height*0.25f, Screen.height*0.25f);
      restart.image.rectTransform.sizeDelta = new Vector2(Screen.height*0.30f, Screen.height*0.18f);
      next.image.rectTransform.sizeDelta = new Vector2(Screen.height*0.30f, Screen.height*0.18f);
    }
    void labelchange(){
      Scene scene = SceneManager.GetActiveScene();
      Car_Label.text = ":" + (GameController.currentCar+1).ToString();
      Time_Label.text = timer.ToString("F");
      Scene_Label.text = scene.name;
    }
    void Update()
    {
      resize_btn();
      labelchange();
      if(MainController.GetComponent<GameController>().isStarted == true){timer -= Time.deltaTime;}
    }
}
