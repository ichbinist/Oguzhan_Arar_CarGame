using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
   [Header("Game Settings")]
   [Tooltip("Add all cars to the array in Scene.")]

    public GameObject[] Cars;
    public static int currentCar;
    public bool isStarted=false;
    public GameObject MainCanvas;
    public Button Button_Left;
    public Button Button_Right;
    private bool leftpressed = false;
    private bool rightpressed = false;
    public float movementSpeed = 2f;
    public float turnspeed = 1f;

    void Start()
    {
        currentCar = 0;
        Cars[0].GetComponent<Car_Properties>().isPlayable = true;
      UIVisibility(true,false);
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

    public void UIVisibility(bool maingame, bool finishscreen){
      MainCanvas.transform.Find("MainGameCanvas").gameObject.SetActive(maingame); //Oyun tuşları
      MainCanvas.transform.Find("finishScreen").gameObject.SetActive(finishscreen); //Bitiriş ekranı
    }

    void Update()
    {
      if(isStarted){//Süre başldığında

        if(Cars[Cars.Length-1].GetComponent<Car_Properties>().isFinished == true){//Dizideki son araç hedefine ulaştıysa
          isStarted = false; //Bölümü bitir.
          UIVisibility(false,true);

      }else{ //Dizideki son araç yerine ulaşmadıysa

        if(leftpressed){Cars[currentCar].transform.Rotate(-Vector3.up * movementSpeed*turnspeed*65f * Time.deltaTime);} //Sol tuşa basıldıysa
        if(rightpressed){Cars[currentCar].transform.Rotate(Vector3.up * movementSpeed*turnspeed*65f * Time.deltaTime);} //Sağ tuşa basıldıysa

      for(int i = 0;i<Cars.Length;i++){ //Araçlar dizisinde gezer
          if(Cars[i].GetComponent<Car_Properties>().isFinished == false){ //bulunan araç yerine ulaşmamışsa onu oynanabilir yap ve şuanki araç verisini o aracın dizideki yeriyle eşitle
            Cars[i].GetComponent<Car_Properties>().isPlayable = true;
            currentCar = i;
            if(MainCanvas.GetComponent<Label_Controls>().timer <= 0 || Cars[i].GetComponent<Car_Properties>().engel == true){ //Araç bir yere çarptıysa veya süresi bittiyse
              isStarted = false;
              Cars[i].GetComponent<Car_Properties>().reset();
            }
            break; // Oynanacak araç bulunduğu için looptan çık
          }else{
            if(Cars[i].GetComponent<Car_Properties>().isPlayable == true) //Araç yerine ulaşmış ancak hala oynanabilir durumdaysa
            {Cars[i].GetComponent<Car_Properties>().isPlayable = false; isStarted = false;}   //aracın oynanabilirliğini kaldır ve süreyi sıfırla

               }}
      Cars[currentCar].transform.position += Cars[currentCar].transform.forward * Time.deltaTime * movementSpeed; //Oyun başladıysa araç ileri gitmeye başlayacak
    }
      }else{//Süre durduğunda
            MainCanvas.GetComponent<Label_Controls>().timer = 10f; //Süreyi sıfırla
           }
    }
}
