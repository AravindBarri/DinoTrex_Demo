using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    private float movementspeed = 1f;
    public float jumpforce;

    private Rigidbody myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forwardmove = transform.right * movementspeed * Time.fixedDeltaTime; //to control the speed of the player
        myrigidbody.MovePosition(myrigidbody.position + forwardmove); //gives continuous movement to forward
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            myrigidbody.velocity = new Vector3(myrigidbody.velocity.x, jumpforce, myrigidbody.velocity.z); //adds force to jump
        }
    }
}
