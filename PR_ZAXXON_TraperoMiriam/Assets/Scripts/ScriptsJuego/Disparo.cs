using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public GameObject bala;
    public Transform spawnPoint;
    public float shotForce = 1500;
    public float shotRate = 0.5f;
    float shotRateTime = 0;

    private void Update()
    {
        if (Input.GetButtonDown("Disparo"))
        {
            if(Time.time>shotRateTime)
            {
                print("se dispara");

                GameObject newBala;

                newBala = Instantiate(bala, spawnPoint.position, spawnPoint.rotation);

                newBala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBala, 2);
            }
        }

    }
}
