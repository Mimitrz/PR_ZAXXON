using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEstrella : MonoBehaviour
{
    [SerializeField] GameObject estrella;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Puntos")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }

}
