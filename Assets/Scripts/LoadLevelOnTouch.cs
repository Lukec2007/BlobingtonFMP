using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnTouch : MonoBehaviour
{
    // Name of the scene to load
    public string levelToLoad = "Level2";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player touches the specific GameObject
        if (other.CompareTag("LevelChanger"))
        {
            // Load the specified level
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
