using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionarNave : MonoBehaviour
{
    [SerializeField] MeshRenderer naveMesh;
    public InitGame initgame;

    private void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.CompareTag("Nave"))
        {
            naveMesh.enabled = false;
           
        }
    }
}
