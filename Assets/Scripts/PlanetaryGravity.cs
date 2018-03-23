using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaryGravity : MonoBehaviour
{
    public GameObject originPlanet;
    public Transform source;
    public float gravityAmount = 9.8f;

    private Rigidbody myRigidbody;

    private SoundManager soundManager;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        soundManager = originPlanet.GetComponent<SoundManager>();
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

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "Ball") {
            float force = Mathf.Clamp01(collision.relativeVelocity.magnitude);
            soundManager.PlaySound(force);
        }
	}
}
