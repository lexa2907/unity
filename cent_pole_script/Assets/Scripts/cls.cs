using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cls : MonoBehaviour
{
    public float v;
    private float p;
    private float e;
    private float g = 9.8f;
    private float t = 0;


    void Start()
    {
        float x = transform.position.x;
        float y = transform.position.y;

        e = Mathf.Sqrt(1 + Mathf.Pow(v * Mathf.Cos(Mathf.Pow(Mathf.PI,2) / 360) / (g * Mathf.Sqrt(x * x + y * y)), 2) * (v * v - 2 * g * Mathf.Sqrt(x * x + y * y)));
        p = Mathf.Pow(v * Mathf.Cos(Mathf.Pow(Mathf.PI,2) / 360),2) / g;
    }


    
    void Update()
    {
        t += Time.deltaTime;
        transform.position = new Vector3((p / (1 + e * Mathf.Cos(t))) * Mathf.Cos(t), (p / (1 + e * Mathf.Cos(t))) * Mathf.Sin(t), 0);
    }
}
