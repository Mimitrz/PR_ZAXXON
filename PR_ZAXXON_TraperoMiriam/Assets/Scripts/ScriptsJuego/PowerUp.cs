using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    bool hit = false;
    public GameObject pickupEffect;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Nave") && !hit)
        {
            
            Pickup();
            hit = true;
        }
    }

    void Pickup()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        GameManager.globalScore++;
        Destroy(gameObject);
    }

}