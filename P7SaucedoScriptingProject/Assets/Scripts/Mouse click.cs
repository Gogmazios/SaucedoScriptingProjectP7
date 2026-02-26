using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouseclick : MonoBehaviour
{

    private Rigidbody rbg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   


    private void Awake()
    {
        rbg = GetComponent<Rigidbody>();
    }

    // Left click to make box go brrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr
    void OnMouseDown ()
    {
        rbg.AddForce(-transform.forward * 1500);
        rbg.useGravity = true; 
    }








}
