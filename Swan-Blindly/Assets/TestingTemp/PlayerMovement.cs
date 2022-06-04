using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rB;
    [SerializeField] private float force = 20;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
            rB.velocity = new Vector3(-force, 0, 0);
        else if (Input.GetKey(KeyCode.D))
            rB.velocity = new Vector3(force, 0, 0);

    }




    //using AddForce
    //if (Input.GetKey(KeyCode.A))
    //      rB.AddForce(transform.right* -force);
    //else if (Input.GetKey(KeyCode.D)) 
    //      rB.AddForce(transform.right* force);

    //using velocity
    //if(Input.GetKey(KeyCode.A))
    //    rB.velocity = new Vector3(-force, 0, 0);
    //else if(Input.GetKey(KeyCode.D))
    //    rB.velocity = new Vector3(force, 0, 0);
}
