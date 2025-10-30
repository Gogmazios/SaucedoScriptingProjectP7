using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSynax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 5f) 
        {
            Debug.Log("Yo I'm about to hit thy ground!");
        }
    }
}
