using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float rotationspeed = 100f;
    public InitGame inicioJuego;

    // Start is called before the first frame update
    void Start()
    {
        inicioJuego = GameObject.Find("InicioDeJuego").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();

    }




    void MoverNave()
    {
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        float desplR = Input.GetAxis("Rotacion");

        float posX = transform.position.x;
        float posY = transform.position.y;

        float limiteX = 15f;
        float limiteY = 15f;
        float menoslimiteY = 2f;

        if ((posX < limiteX || desplX < 0f) && (posX > -limiteX || desplX > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        }

        if ((posY < limiteY || desplY < 0f) && (posY > menoslimiteY || desplY > 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World);
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = inicioJuego.juegoSpeed;

        if (other.gameObject.layer == 6)
        {
            inicioJuego.juegoSpeed = 0f;
            
            inicioJuego.alive = false;
        }
    }
}
