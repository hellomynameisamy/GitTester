using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float speed;

    private void Start()
    {

        offset = transform.position - player.transform.position;
        speed = 0.1f;
    }
    // void FixedUpdate()
    // {
    //      if(Input.GetKey(KeyCode.Q))
    //      {
    //          transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
    //      }
    //      if(Input.GetKey(KeyCode.E))
    //      {
    //          transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
    //      }
    // }
        void LateUpdate()
    {
            // if(Input.GetKey(KeyCode.Space))
            transform.position = player.transform.position + offset;
    }
    
}
