using UnityEngine;
using System.Collections.Generic;

public class Counter : MonoBehaviour
{
    private int value = 0;

    private HashSet<GameObject> touchedObjects = new HashSet<GameObject>();

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !touchedObjects.Contains(gameObject))
        {
            value++;
            touchedObjects.Add(gameObject);
            Debug.Log("Value incremented to: " + value);

            // Disable IsTrigger on the player's collider after touching the cube once
            Collider playerCollider = other.GetComponent<Collider>();
            if (playerCollider != null)
            {
                playerCollider.isTrigger = false;
                Debug.Log("Player collider IsTrigger disabled.");
            }
        }
    }
}
