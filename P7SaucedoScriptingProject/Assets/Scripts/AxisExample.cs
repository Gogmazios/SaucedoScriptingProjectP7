using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AxisExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public float range;
    public Text textOutput; 
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
      // Debug.Log("textOutput.text") = "Value Returned: " + h.ToString("F2");
    }
}
