using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    
  /*  public Rigidbody balaPrefab;
    public Transform canon;
    float disparador;
    public float tiempoDisparo = 0.1f;
    float speedDisparo = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Disparar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bala")
        {
            Destroy(other.gameObject);
        }
    }*

    void Disparar()
    {
        if(Input.GetKeyDown("space") && Time.time > disparador)
        {
            disparador = Time.time + tiempoDisparo;
            Rigidbody balaPrefabInstac;
            balaPrefabInstac = Instantiate(balaPrefab, disparador.position, Quaternion.identity);
            balaPrefabInstac.AddForce(disparador.forward * 100 * speedDisparo);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * 15f);
    }*/
}
