using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuSettings : MonoBehaviour
{
    public Button start;
    public Text header;
    void Start()
    {
      resize_btn();
    }

    void resize_btn(){
      start.image.rectTransform.sizeDelta = new Vector2(Screen.width*0.1f, Screen.height*0.06f);
      header.rectTransform.sizeDelta = new Vector2(Screen.width*0.40f, Screen.height*0.40f);
    }
}
