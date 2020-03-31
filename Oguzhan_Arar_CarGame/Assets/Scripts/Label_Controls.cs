using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Label_Controls : MonoBehaviour
{
  public Text Time_Label;
  public Text Car_Label;
  public Text Scene_Label;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Car_Label.text = ":" + GameController.currentCar.ToString();
    }
}
