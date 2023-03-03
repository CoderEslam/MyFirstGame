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
    }
}
