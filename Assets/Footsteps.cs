using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsSound;
    public float normalSpeed = 1.0f; // Default playback speed
    public float fastSpeed = 1.5f;   // Faster playback speed

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footstepsSound.enabled = true;

            // Adjust pitch based on modifier key (e.g., holding Left Shift for faster movement)
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.pitch = fastSpeed; // Increase pitch for faster movement
            }
            else
            {
                footstepsSound.pitch = normalSpeed; // Normal pitch
            }
        }
        else
        {
            footstepsSound.enabled = false;
        }
    }
}