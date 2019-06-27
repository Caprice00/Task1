using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody playerRb;
    public float speed = 10f;
   // public Vector2 Direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            playerRb.velocity = new Vector3(-speed*Time.fixedDeltaTime, 0, 0);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            playerRb.velocity = new Vector3(speed*Time.fixedDeltaTime, 0, 0);
        }

        
    }
}
