using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningWalls : MonoBehaviour
{
  public float wallturnspeed = 1.5f;
    void Update()
    {
        gameObject.transform.Rotate(-Vector3.up * wallturnspeed*65f * Time.deltaTime);
    }
}
