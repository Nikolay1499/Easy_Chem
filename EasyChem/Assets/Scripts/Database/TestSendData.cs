using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestSendData : MonoBehaviour {

    string id;
    public string UserURL;
    public void ChangeData(int sceneindex)
    {
        id = PlayerPrefs.GetString("userID");
        WWWForm form = new WWWForm();
        form.AddField("IDPost", id);
        WWW www = new WWW(UserURL, form);
        SceneManager.LoadSceneAsync(sceneindex);
    }
}
