using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 50f;
    public float rotSpeed = 5000f;
    public float jumpSpeed = 30;


    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float movZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotY = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        float movY = 0;
        if (Input.GetButtonDown("Jump"))
        {
            movY = jumpSpeed * Time.deltaTime;
        }
        transform.Translate(movX, movY, movZ);
        transform.Rotate(0, rotY, 0);
    }
    
        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("You Dead");
            GetComponent<Renderer>().material.color = Color.red;
            Time.timeScale = 0;
        }
    }
}

