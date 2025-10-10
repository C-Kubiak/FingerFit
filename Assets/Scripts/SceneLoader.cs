using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Time.timeScale = 1f; // reset time scale
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

}
