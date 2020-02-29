using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    bool myBool;
    public Rigidbody rb;
    public float movementSpeed;
    public Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBool = false;

        if (Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed * 2.5f;
            myBool = true;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
            myBool = true;
        }
        if (Input.GetKey("s"))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movementSpeed * 2.5f;
            myBool = true;
        }
        if (Input.GetKey("a"))
        {
            transform.position += transform.TransformDirection(Vector3.forward * -1) * Time.deltaTime * movementSpeed * 2.5f;
            myBool = true;
        }
        if (Input.GetKey("f"))
        {
            rb.AddForce(vec);
        }

        if (myBool)
        {
            GetComponent<Animator>().enabled = true;
        }
        else
        {
            GetComponent<Animator>().enabled = false;
        }
    }
}