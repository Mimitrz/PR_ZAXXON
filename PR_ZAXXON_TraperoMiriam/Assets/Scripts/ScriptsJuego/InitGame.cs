using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public float juegoSpeed;
    public bool alive;
    public float obstdistancia = 30f;
    // Start is called before the first frame update
    void Start()
    {
        juegoSpeed = 40f;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
