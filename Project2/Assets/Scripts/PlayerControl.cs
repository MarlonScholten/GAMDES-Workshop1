using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed = 5f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
            GetComponent<Rigidbody>().AddForce(new Vector3(-movementSpeed, 0, 0));
        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().AddForce(new Vector3(movementSpeed, 0, 0));
        if (Input.GetKey(KeyCode.W))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, movementSpeed));
        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -movementSpeed));
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(""))
        {
            
        }
    }
}