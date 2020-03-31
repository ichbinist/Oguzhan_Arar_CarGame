using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] Cars;
    public static int currentCar;
    void Start()
    {
        currentCar = 1;
    }


    void Update()
    {
      for(int i = 0;i<Cars.Length;i++){
          if(Cars[i].GetComponent<Car_Properties>().isFinished == false){
            Cars[i].GetComponent<Car_Properties>().isPlayable = true;
            currentCar = i+1;
            break;
          }else{
            Cars[i].GetComponent<Car_Properties>().isPlayable = false;
          }
      }
    }
}
