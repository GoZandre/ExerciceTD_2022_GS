using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    public void QuitGame()
    {
        //Debug.Log("TryingToQuit");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }
}
