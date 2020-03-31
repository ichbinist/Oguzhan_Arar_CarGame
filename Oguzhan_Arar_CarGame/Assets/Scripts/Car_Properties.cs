using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Properties : MonoBehaviour
{
  public Color color;
  public GameObject Start_Zone;
  public GameObject Finish_Zone;
  public bool isPlayable=false;
  public bool isFinished=false;
    void Start()
    {
        this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", color);
    }

    // Update is called once per frame
    void Update()
    {
      if(isPlayable){Start_Zone.SetActive(true); Finish_Zone.SetActive(true);}else{Start_Zone.SetActive(false); Finish_Zone.SetActive(false);}
    }
}
