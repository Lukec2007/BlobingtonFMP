using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathWall : MonoBehaviour
{

    public string levelToLoad = "Level2";

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("DeathWall"))
        {

            SceneManager.LoadScene(levelToLoad);
        }
    }
}
