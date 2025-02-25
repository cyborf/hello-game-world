using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{ 
    public GameObject UIObject;


    public float speed = 2f;

    public float rot = 100f;

    public ParticleSystem yourParticleSystem;

    void Start()
    {
        UIObject.SetActive(false);
    }
    void FixedUpdate()
    {
        // deteriorate
        if (rot <= 100 && rot >= 0) {
            rot -= 1 * Time.deltaTime * speed;
        }

        // normal
        if (rot < 100 && rot >= 90) transform.parent.gameObject.GetComponent<Renderer>().material.color = Color.green;
        // medium rot
        if(rot < 50 && rot >= 10) transform.parent.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        // normal rot
        if (rot < 90 && rot >= 50) 
        {
            
            transform.parent.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        }
        // insane rot
        if (rot < 10) {
            yourParticleSystem.Play();
            transform.parent.gameObject.GetComponent<Renderer>().material.color = Color.black;
            UIObject.SetActive(true);

        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.name);

        if (other.name == "Player")
        {
            yourParticleSystem.Pause();
            transform.parent.gameObject.GetComponent<Renderer>().material.color = Color.green;
            rot = 100;
            Debug.Log("Player Collided with CUBE");
        }

    }
}
