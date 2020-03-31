﻿using System.Collections;
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
        gameObject.transform.position = Start_Zone.transform.position;
        gameObject.transform.rotation = Start_Zone.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
      if(isPlayable){Start_Zone.SetActive(true); Finish_Zone.SetActive(true);}else{Start_Zone.SetActive(false); Finish_Zone.SetActive(false);}


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Start"))
        {
            isFinished=true;
        }
    }
}