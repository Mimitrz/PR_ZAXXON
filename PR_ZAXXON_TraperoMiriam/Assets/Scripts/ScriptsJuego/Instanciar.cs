using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    [SerializeField] GameObject columna;
    [SerializeField] Transform instantiatePos;
    float intervalo;
    [SerializeField] float distance;

    //Acceder al script con las variables generales
    InitGame inicioJuego;


    // Start is called before the first frame update
    void Start()
    {
        //intervalo = 0.5f;
        distance = 30f;
        inicioJuego = GameObject.Find("InicioDeJuego").GetComponent<InitGame>();

        StartCoroutine("CrearColumna");

        //Crear columnas iniciales para el momento donde no hay
        float posZcolumna1 = 150f;
        float posZ = transform.position.z;
        float columnasIniciales = (posZ - posZcolumna1) / distance;

        columnasIniciales = Mathf.Round(columnasIniciales);
        print(columnasIniciales);



    }

    // Update is called once per frame
    void Update()
    {
      
    }

    IEnumerator CrearColumna()
    {
        

        while (true)
        {
            float speed;
            speed = inicioJuego.juegoSpeed;
            intervalo = distance / speed;
            

            float randomX = Random.Range(-20f, 20f);
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(columna, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }


    }


  

    
}
