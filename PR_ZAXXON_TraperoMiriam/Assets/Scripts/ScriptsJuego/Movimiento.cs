using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{

    [SerializeField] float speed;
    //[SerializeField] float rotationspeed = 100f;
    public InitGame inicioJuego;

    // Start is called before the first frame update
    void Start()
    {
        inicioJuego = GameObject.Find("InicioDeJuego").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inicioJuego.alive)
        {
            MoverNave();
        }


    }


    void MoverNave()
    {
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        //float desplR = Input.GetAxis("Rotacion");

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

    //int number = 1;
    //float inicioTiempo = 0f;
    //float finTiempo = 5f;
    
    void OnTriggerEnter(Collider other)
    {
        speed = inicioJuego.juegoSpeed;

        if (other.gameObject.layer == 6)
        {
            inicioJuego.juegoSpeed = 0f;
            //Chocar();
            inicioJuego.alive = false;
            GameObject.Find("EmptyNave").SetActive(false);
            SceneManager.LoadScene(3);


        }
    }

   /* public void Espera()
    {
        inicioTiempo += Time.deltaTime;
        if(inicioTiempo>=finTiempo)
        {
            inicioTiempo = 0f;
            number++;
            SceneManager.LoadScene(3);
        }
    }
    
    public void Chocar()
    {
        print("Hola");
        ConfigVars.numLives--;
        if(ConfigVars.numLives == 0)
        {
            Morir();
        }

    }

    public void Morir()
    {

        inicioJuego.juegoSpeed = 0f;
        inicioJuego.alive = false;
        GameObject.Find("EmptyNave").SetActive(false);
    }
*/
}
