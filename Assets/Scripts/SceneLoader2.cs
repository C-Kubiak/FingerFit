using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2 : MonoBehaviour
{
    public void LoadScene2(string sceneName)
    {
        Time.timeScale = 1f; // Reset time scale if needed

        // Destroy GameManager GameObjects before loading new scene
        GameObject oldManager = GameObject.Find("GameManager");
        if (oldManager != null)
        {
            Destroy(oldManager);
        }

        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
