using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnTouch : MonoBehaviour
{

    public string levelToLoad = "Level2";

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("LevelChanger"))
        {

            SceneManager.LoadScene(levelToLoad);
        }
    }
}
