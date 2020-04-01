using UnityEngine;
using System.Collections;

public class PingPongBackground : MonoBehaviour
{
    private Color color1 = Color.white;
    private Color color2 = Color.yellow;
    public float duration = 2.0F;
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        color2 = new Color(0.75f,0.75f,0.75f,0.75f);
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        cam.backgroundColor = Color.Lerp(color1, color2, t);
    }
}
