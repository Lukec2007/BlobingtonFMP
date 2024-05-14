using UnityEngine;
using UnityEngine.UI;


public class IncrementOnTouch : MonoBehaviour
{
    private int counter = 0;
    private int lastTouchedObjectID = -1;
    public Text scoreText; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable") && lastTouchedObjectID != other.gameObject.GetInstanceID())
        {
            counter++;

            Debug.Log("Counter: " + counter);

            lastTouchedObjectID = other.gameObject.GetInstanceID();
        }
    }

    void Update()
    {
        scoreText.text = counter.ToString();
    }
}
