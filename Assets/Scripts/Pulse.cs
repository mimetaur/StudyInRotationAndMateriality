using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{

    public float amount = 2.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float scale = Mathf.Sin(Time.time) * Time.deltaTime * amount;
        transform.localScale = transform.localScale + new Vector3(scale, scale, scale);
    }
}
