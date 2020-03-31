using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public GameObject[] Cars;
    public static int currentCar;
    public bool isStarted=false;
    public GameObject MainCanvas;
    public Button Button_Left;
    public Button Button_Right;
    private bool leftpressed = false;
    private bool rightpressed = false;
    public float movementSpeed = 2f;

    void Start()
    {
        currentCar = 0;
        Cars[0].GetComponent<Car_Properties>().isPlayable = true;
    }

    //CurrentCar's rotations.
    public void Left_Turn(){
            isStarted = true;
            leftpressed = true;
    }
    public void Left_Turn_Release(){
            leftpressed = false;
    }
    public void Right_Turn(){
            isStarted = true;
            rightpressed = true;
    }
    public void Right_Turn_Release(){
            rightpressed = false;
    }

    void Update()
    {
      if(isStarted){//Süre başldığında
        if(leftpressed){Cars[currentCar].transform.Rotate(-Vector3.up * movementSpeed*65f * Time.deltaTime);}
        if(rightpressed){Cars[currentCar].transform.Rotate(Vector3.up * movementSpeed*65f * Time.deltaTime);}
      for(int i = 0;i<Cars.Length;i++){
          if(Cars[i].GetComponent<Car_Properties>().isFinished == false){
            Cars[i].GetComponent<Car_Properties>().isPlayable = true;
            currentCar = i;
            break;
          }else{
            if(Cars[i].GetComponent<Car_Properties>().isPlayable == true){Cars[i].GetComponent<Car_Properties>().isPlayable = false; isStarted = false;}
               }}    //Araçları playable yapar araç dizisinde gezer
      Cars[currentCar].transform.position += Cars[currentCar].transform.forward * Time.deltaTime * movementSpeed;
      }else{//Süre durduğunda
            MainCanvas.GetComponent<Label_Controls>().timer = 10f;
           }
    }
}
