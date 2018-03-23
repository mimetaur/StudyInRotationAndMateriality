using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaryGravity : MonoBehaviour
{

    public Transform source;
    public float gravityAmount = 9.8f;

    private Rigidbody myRigidbody;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ApplyGravity();
    }

    void ApplyGravity()
    {
        // direction is derviced from subtracting the target from the current position
        // and normalized to only have direction not distance info
        Vector3 direction = source.position - transform.position;
        direction.Normalize();

        // scale to the gravity amount
        Vector3 gravityForce = direction * gravityAmount;

        myRigidbody.AddForce(gravityForce);
    }
}
