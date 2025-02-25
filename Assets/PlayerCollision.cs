using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerCollision : MonoBehaviour
{
    public AudioClip collisionSound;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        AudioSource.PlayClipAtPoint (collisionSound, Camera.main.transform.position);
        Debug.Log("yell yay");
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") 
        {
            if (Input.GetKey("e")) {
                Debug.Log("healed");
            }
        }
    }
}


