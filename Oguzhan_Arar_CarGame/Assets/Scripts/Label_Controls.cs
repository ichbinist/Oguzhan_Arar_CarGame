﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Label_Controls : MonoBehaviour
{
  public Text Time_Label;
  public Text Car_Label;
  public Button btn_right;
  public Button btn_left;
  public float timer = 15f;


  public GameObject MainController;
    void Start()
    {

    }

    void resize_btn(){
      btn_right.image.rectTransform.sizeDelta = new Vector2(Screen.height*0.25f, Screen.height*0.25f);
      btn_left.image.rectTransform.sizeDelta = new Vector2(Screen.height*0.25f, Screen.height*0.25f);
    }
    void labelchange(){
      Scene scene = SceneManager.GetActiveScene();
      Car_Label.text = ":" + (GameController.currentCar+1).ToString();
      Time_Label.text = timer.ToString("F");
    }
    void Update()
    {
      resize_btn();
      labelchange();
      if(MainController.GetComponent<GameController>().isStarted == true){timer -= Time.deltaTime;}
    }
}
