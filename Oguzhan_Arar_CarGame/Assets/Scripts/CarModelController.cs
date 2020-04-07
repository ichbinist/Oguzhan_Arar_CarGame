using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarModelController : MonoBehaviour
{
    public Color Car_Color;
    [SerializeField]
    private int R = 128,G = 128,B = 0;
    private GameObject menucar;
    void Update (){
      if(Application.loadedLevel == 0){
        menucar = GameObject.Find("Menu_Car").gameObject;
        menucar.gameObject.GetComponent<Renderer>().material.color = Car_Color;
      }
       Car_Color = new Color(R/255f,G/255f,B/255f);
    }

    public void ColorChange(){
        R = Random.Range(40, 255);
        G = Random.Range(40, 255);
        B = Random.Range(40, 255);
    }
}
