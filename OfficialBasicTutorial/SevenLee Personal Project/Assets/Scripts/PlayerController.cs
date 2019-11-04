using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    private float moveX;
    private float moveY;
    private Rigidbody rb;

    //public Vector3 oldPlayerPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //private void LateUpdate()
    //{
    //    oldPlayerPosition = transform.position;
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("我按下了空格, 这时候moveX = " + moveX+",moveY = " + moveY);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            //rb.Sleep();
            //rb.WakeUp();
            //rb.constraints = RigidbodyConstraints.FreezeAll;
            //rb.constraints = RigidbodyConstraints.None;
        }
        else
        {
            moveX = Input.GetAxis("Horizontal");
            moveY = Input.GetAxis("Vertical");
            //transform.Translate(new Vector3(moveX, 0,moveY) * speed * Time.deltaTime);
            rb.AddForce(new Vector3(moveX, 0, moveY) * speed);
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("我出去了");
    //    transform.position = oldPlayerPosition;
    //    GetComponent<Rigidbody>().velocity = Vector3.zero;
    //    GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    //}
}
