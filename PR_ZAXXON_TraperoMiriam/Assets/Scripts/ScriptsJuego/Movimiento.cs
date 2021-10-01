using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{


    [SerializeField] float speed;
    [SerializeField] float rotationspeed=100f;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x;


        //Movimientos y rotacion
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplY, Space.World); 
        float desplR = Input.GetAxis("Rotacion");
        transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationspeed);

        //Limites
        if (posX > 10f && desplX > 0f)
        {
            transform.position = new Vector3 (posX, transform.position.y, transform.position.z);

        }
      
    
    
    }


}
