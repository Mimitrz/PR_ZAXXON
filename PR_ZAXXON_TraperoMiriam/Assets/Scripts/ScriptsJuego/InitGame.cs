using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{
    public float juegoSpeed;
    public bool alive;
    public float obstdistancia = 30f;
    [SerializeField] Text scoreTx;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.globalScore = 0;
        juegoSpeed = 40f;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTx.text = "Score: "+GameManager.globalScore;
    }
}
