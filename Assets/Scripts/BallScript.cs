﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public float velocityScale;
    public Rigidbody sphereBody;
    public Vector3 velocity;

    // Use this for initialization
    void Awake() {
        Debug.Log("Initializing new ball.");
        sphereBody = GetComponent<Rigidbody>();
    }

    void Start () {
        
    }

    public void SetVelocity(Vector2 i_velocity)
    {
        sphereBody.velocity = i_velocity;
        velocity = i_velocity;
    }
    public Vector2 GetVelocity()
    {
        return sphereBody.velocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            velocity = sphereBody.velocity;
        }
<<<<<<< HEAD
        if(collision.gameObject.tag == "Player")
        {

            //Destroy(collision.gameObject);
        }
=======
>>>>>>> bd3b4e9767514ed46c1d3afd1c08955c444958b7
    }

    void Update () {
        sphereBody.velocity = velocity;
    }
}
