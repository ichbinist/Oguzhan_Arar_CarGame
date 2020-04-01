using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuSettings : MonoBehaviour
{
    public Button start;
    public GameObject Scenepanels;
    public GameObject Buttonpanels;

    public Text header;
    public float ratioHeader = 0.3f;
    public float ratioButton = 1.4f;
    public GameObject Menu_car;
    public float turnspeed = 2f;
    void Update()
    {
      resize_btn();
      car_rotate();
    }
    void resize_btn(){
      start.image.rectTransform.sizeDelta = new Vector2(Screen.width*0.1f*ratioButton, Screen.height*0.025f*ratioButton);
      header.rectTransform.sizeDelta = new Vector2(Screen.width*0.20f*ratioHeader, Screen.height*0.20f*ratioHeader);
    }
    void car_rotate(){
      Menu_car.transform.Rotate(-Vector3.up * turnspeed *35f * Time.deltaTime);
    }
  public void startButton(){
      Buttonpanels.SetActive(false);
      Scenepanels.SetActive(true);
    }
  public void backButton(){
      Buttonpanels.SetActive(true);
      Scenepanels.SetActive(false);
    }
}
