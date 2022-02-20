using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEstrella : MonoBehaviour
{
    //AudioSource audioSource;
    //[SerializeField] AudioClip estrella;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Estrella")
        {
           // audioSource.PlayOneShot(estrella, 1f);
            Destroy(gameObject);
        }
    }

}
