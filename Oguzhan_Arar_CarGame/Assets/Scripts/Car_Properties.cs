using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Properties : MonoBehaviour
{
  private Color color;
  public GameObject Start_Zone;
  public GameObject Finish_Zone;
  public bool isPlayable=false;
  public bool isFinished=false;
  public bool engel = false;
  private GameObject menucarcontrol;
    void Start()
    {
        menucarcontrol = GameObject.Find("Car_Model_Control");
        this.gameObject.GetComponent<Renderer>().material.color = menucarcontrol.GetComponent<CarModelController>().Car_Color;
        reset();
        this.gameObject.GetComponent<Renderer>().enabled = false;
    }

    void FixedUpdate()
    {
      if(isPlayable){Start_Zone.SetActive(true);Finish_Zone.SetActive(true);}else{Start_Zone.SetActive(false); Finish_Zone.SetActive(false);}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine")){isFinished=true;}
        if (other.CompareTag("Engel")){engel = true;}
    }

public void reset(){
  gameObject.transform.position = Start_Zone.transform.position;
  gameObject.transform.rotation = Start_Zone.transform.rotation;
  engel = false;
}

}
