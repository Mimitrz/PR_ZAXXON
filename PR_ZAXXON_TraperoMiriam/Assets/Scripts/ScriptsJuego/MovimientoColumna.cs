using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoColumna : MonoBehaviour
{
    float naveSpeed;
    
   
    // Start is called before the first frame update
    void Start()
    {
        naveSpeed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * naveSpeed);
    }
}
