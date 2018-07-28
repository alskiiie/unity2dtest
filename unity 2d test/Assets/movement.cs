using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //moves object to the right
        if (Input.GetKeyDown("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }

        //moves object to the left
        if (Input.GetKeyDown("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }

        //moves object up
        if (Input.GetKeyDown("w"))
        {
            transform.Translate(0f, speed * Time.deltaTime, 0f);
        }

        //moves object down
        if (Input.GetKeyDown("s"))
        {
            transform.Translate(0f, -speed * Time.deltaTime, 0f);
        }


    }
}
