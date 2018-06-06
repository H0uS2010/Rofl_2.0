using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 0.2f;
    public float distance = 10;
	
	void Start ()
    {
        Debug.Log(speed);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x >= distance || transform.position.x <= -distance) 
        {
            speed = -speed;
        }
        transform.Translate(speed, 0, 0);

    }
}
