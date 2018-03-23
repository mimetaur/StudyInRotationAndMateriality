using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{

    public float speed = 1.0f;
    public float massEffect = 10.0f;
    private Rigidbody myRigidbody;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.mass = myRigidbody.mass * transform.localScale.z * massEffect;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 amount = transform.forward * speed;
        myRigidbody.AddRelativeForce(amount);
    }
}
