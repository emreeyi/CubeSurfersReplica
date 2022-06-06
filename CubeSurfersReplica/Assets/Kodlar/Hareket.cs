using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float ileriHiz;
    public float yonHiz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal")*Time.deltaTime*yonHiz;
        this.transform.Translate(yatay, 0, ileriHiz * Time.deltaTime);

    }
}
