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
    void Start()
    {

        this.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.7f, 1f); //Araç renklerini rastgele seç
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
