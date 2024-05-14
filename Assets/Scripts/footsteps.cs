using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSound, sprintSound, flySound;
    private bool isFlying = false;

    void Update()
    {
  
        bool isFlySoundPlaying = flySound.isPlaying;


        bool movementKeyPressed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

        if (movementKeyPressed)
        {
 
            if (Input.GetKey(KeyCode.LeftShift))
            {

                if (!isFlySoundPlaying)
                {
                    footstepsSound.enabled = false;
                    sprintSound.enabled = true;
                }
                else
                {
                    footstepsSound.enabled = false;
                    sprintSound.enabled = false;
                }
            }
            else
            {

                if (!isFlySoundPlaying)
                {
                    footstepsSound.enabled = true;
                    sprintSound.enabled = false;
                }
                else
                {
                    footstepsSound.enabled = false;
                    sprintSound.enabled = false;
                }
            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            isFlying = !isFlying;
            flySound.enabled = isFlying;
        }
    }
}


