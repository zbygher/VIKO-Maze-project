using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;
    private Vector3 input;
    public Rigidbody rb;
    private float maxSpeed = 5f;
    private Vector3 spawn;

    // Use this for initialization
    void Start () {
        spawn = transform.position;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(input * moveSpeed);
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
            transform.position = spawn;
        }
    }




}
