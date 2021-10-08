using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    [SerializeField] GameObject columna;
    [SerializeField] Transform instantiatePos;
    float intervalo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.5f;

        StartCoroutine("CrearColumna");
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    IEnumerator CrearColumna()
    {
        while (true)
        {
            float randomX = Random.Range(-15f, 15f);
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(columna, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }


    }


  

    
}
