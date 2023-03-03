using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello from unity Start eslam ghazy");
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Hello from unity update");
       // if user click on space button
       if (Input.GetKeyDown("space"))
       {
           GetComponent<Rigidbody>().velocity = new Vector3(0,5,0); // to move player in one direction only vector 3 ==> y axis
       }

       if (Input.GetKey("up"))
       {
           GetComponent<Rigidbody>().velocity = new Vector3(0,0,5); // to move player in one direction only vector z ==> y axis
       }
       
       if (Input.GetKey("right"))
       {
           GetComponent<Rigidbody>().velocity = new Vector3(5,0,0); // to move player in one direction only vector x ==> y axis
       }
       
       if (Input.GetKey("left"))
       {
           GetComponent<Rigidbody>().velocity = new Vector3(-5,0,0); // to move player in one direction only vector x ==> y axis
       }
       
       if (Input.GetKey("down"))
       {
           GetComponent<Rigidbody>().velocity = new Vector3(0,0,-5); // to move player in one direction only vector x ==> y axis
       }
    }
}
