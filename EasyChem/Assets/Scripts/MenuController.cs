using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class  MenuController: MonoBehaviour
{
    public Text id;
    public GameObject fac;
    void Start()
    {
        Screen.autorotateToPortrait = false;
    }
    public void loadbyindex(int sceneindex)
    { 
        if (PlayerPrefs.GetString("userID") == "")
        {
            fac.SetActive(true);
        }
        else
        {
            SceneManager.LoadSceneAsync(sceneindex);
            Time.timeScale = 1;
        }
    }
}
