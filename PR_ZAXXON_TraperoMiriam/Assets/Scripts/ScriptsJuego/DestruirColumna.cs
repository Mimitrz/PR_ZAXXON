using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirColumna : MonoBehaviour
{
    float destroyPosition = -12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (transform.position.z <= destroyPosition)
        {
            Destroy(gameObject);
        }

    }
}
