using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSound, sprintSound, flySound;
    private bool isFlying = false;

    void Update()
    {
        // Check if W, A, S, or D keys are held down
        bool movementKeyPressed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

        if (movementKeyPressed)
        {
            // Check if LeftShift is held down
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }

        // Toggle fly sound on/off when F is clicked
        if (Input.GetKeyDown(KeyCode.F))
        {
            isFlying = !isFlying;
            flySound.enabled = isFlying;
        }
    }
}


