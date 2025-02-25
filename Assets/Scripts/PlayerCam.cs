using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    private void Start()
    {
        // Cursor is in the middle of the screen, and also not visible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame. Using FixedUpdate for physics.
    // not good for one-off actions like jumping. 
    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        // set the rotation
        yRotation += mouseX;
        xRotation -= mouseY;
        // cap the rotation for a realistic experience
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        // rotate camera and orientation, some physics that I don't understand is happening here.
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}

