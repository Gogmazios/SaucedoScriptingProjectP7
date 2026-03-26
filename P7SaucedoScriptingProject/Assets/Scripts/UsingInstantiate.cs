using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody RP;
    //RP = RocketPrfab
    //BE = barrelEnd
    public Transform BE; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
           rocketInstance = Instantiate(RP, BE.position, BE.rotation) as Rigidbody;
            rocketInstance.AddForce(BE.forward * 1000); 

        }



    }
}
