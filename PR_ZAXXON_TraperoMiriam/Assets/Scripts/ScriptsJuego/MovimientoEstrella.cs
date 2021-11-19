using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEstrella : MonoBehaviour
{
    float speed;
    public InitGame inicioJuego;

    // Start is called before the first frame update
    void Start()
    {
        inicioJuego = GameObject.Find("InicioDeJuego").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = inicioJuego.juegoSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
