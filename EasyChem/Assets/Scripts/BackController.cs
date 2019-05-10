using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackController : MonoBehaviour
{
    void Start()
    {
        Screen.autorotateToPortrait = false;
    }

    public void loadbyindex(int sceneindex)
    {
        SceneManager.LoadSceneAsync(sceneindex);
        Time.timeScale = 1;
    }
}