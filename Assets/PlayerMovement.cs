using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public CharacterController controller;

    public float speed = 12f;

    public float power = 100f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; 

        controller.Move(move * speed * Time.deltaTime);
        
    }

    void FixedUpdate()
    {
        if (power<100)
        {
            power += 1;
        }
        if (Input.GetKey("e"))
        {
            if (power > 10) power -= 10;
            
        }

    }
}
