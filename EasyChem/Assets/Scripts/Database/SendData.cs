using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SendData : MonoBehaviour {

	string id;
    string UserURL = "http://easychem.comze.com/InsertData.php";
    public void ChangeData(int sceneindex)
    {
        id = PlayerPrefs.GetString("userID");
        WWWForm form = new WWWForm();
        form.AddField("IDPost", id);
        WWW www = new WWW(UserURL, form);
        SceneManager.LoadSceneAsync(sceneindex);
    }
}
