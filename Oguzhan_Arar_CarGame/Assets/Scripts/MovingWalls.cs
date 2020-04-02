using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour
{
    private Vector3 pos1;
    private Vector3 pos2;
    public float speed = 1.5f;
    private GameObject position1;
    private GameObject position2;

    void Start()
    {
    position1 = transform.Find("Position1").gameObject;
    position2 = transform.Find("Position2").gameObject;

    pos1 = position1.transform.position;
    pos2 = position2.transform.position;

    Destroy(position1);
    Destroy(position2);
    }

    void Update()
    {
          transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
