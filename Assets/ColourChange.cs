using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public Color newColor = Color.red;


    private Renderer rend;


    private bool isTouched = false;

    void Start()
    {

        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {


        Debug.Log("Trigger entered!");
        // Check if the object has been touched by the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched the object!");
            // Change the color only if it hasn't been touched before
            if (!isTouched)
            {
                Debug.Log("Changing color!");
                // Change the color to the new color
                rend.material.color = newColor;
                // Set isTouched to true to prevent multiple color changes
                isTouched = true;
            }
        }
    }

}
