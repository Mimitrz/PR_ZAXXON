using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoColumna : MonoBehaviour
{
    float speed; 

    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
