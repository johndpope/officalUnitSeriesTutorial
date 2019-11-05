using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody rb;
    public float zDestroy = 7;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        if(transform.position.z > zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
