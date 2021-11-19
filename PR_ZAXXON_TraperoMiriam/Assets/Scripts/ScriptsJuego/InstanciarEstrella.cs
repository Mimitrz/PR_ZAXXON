using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarEstrella : MonoBehaviour
{
    [SerializeField] GameObject estrella;
    [SerializeField] Transform instantiatePosEs;
    float intervalo;
    [SerializeField] float distance;

    public InitGame inicioJuego;

    // Start is called before the first frame update
    void Start()
    {
        inicioJuego = GameObject.Find("InicioDeJuego").GetComponent<InitGame>();
        distance = 90f;
       

        StartCoroutine("CrearEstrella");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CrearEstrella()
    {


        while (true)
        {
            float speed;
            speed = inicioJuego.juegoSpeed;
            intervalo = distance / speed;


            float randomX = Random.Range(-15f, 15f);
            float randomY = Random.Range(1f, 10f);

            Vector3 newPos = new Vector3(randomX, randomY, instantiatePosEs.position.z);
            Instantiate(estrella, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }


    }

}
