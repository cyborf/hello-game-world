using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource playSound;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        if (other.tag == "Player") {
            Debug.Log ("SFX triggered");
            playSound.Play();
        }
        
    }
}
