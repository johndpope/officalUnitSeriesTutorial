using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constraint : MonoBehaviour
{
    public Vector3 oldPlayerPosition;
    public GameObject player;
    public Collider thisCollider;
    public float maxX, maxZ, minX, minZ;

    // Start is called before the first frame update
    void Start()
    {
        thisCollider = GetComponent<BoxCollider>();
        maxX = thisCollider.bounds.center.x + thisCollider.bounds.size.x / 2;
        maxZ = thisCollider.bounds.center.z + thisCollider.bounds.size.z / 2;

        minX = thisCollider.bounds.center.x - thisCollider.bounds.size.x / 2;
        minZ = thisCollider.bounds.center.z - thisCollider.bounds.size.z / 2;

        Debug.Log(thisCollider.bounds.center.z + "  " + thisCollider.bounds.size.z);


        //maxX = thisCollider.bounds.center.x + thisCollider.bounds.size.x / 2;
        //maxZ = (1 + thisCollider.bounds.center.z) * transform.position.z + (thisCollider.bounds.size.z * transform.lossyScale.z) / 2;

        //minX = thisCollider.bounds.center.x - thisCollider.bounds.size.x / 2;
        //minZ = (1 + thisCollider.bounds.center.z) * transform.position.z - (thisCollider.bounds.size.z * transform.lossyScale.z) / 2;
    }


    // Update is called once per frame
    void Update()
    {
        //超出box collider的边界 就给player拽回来 并且 静止
        if(player.transform.position.x > maxX)
        {
            player.transform.position = new Vector3(maxX, player.transform.position.y, player.transform.position.z);
            StopPlayer();
        }
        if (player.transform.position.z > maxZ)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, maxZ);
            StopPlayer();
        }
        if (player.transform.position.x < minX)
        {
            player.transform.position = new Vector3(minX, player.transform.position.y, player.transform.position.z);
            StopPlayer();
        }
        if (player.transform.position.z < minZ)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, minZ);
            StopPlayer();
        }

    }

    void StopPlayer()
    {
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

}
