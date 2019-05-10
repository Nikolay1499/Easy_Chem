using UnityEngine;
using System.Collections;

public class ElSendData : MonoBehaviour {

    public string UserURL;
    string value;
    public GameObject element;
    void Start()
    {
        if (element.activeInHierarchy == true)
        {
            value = PlayerPrefs.GetString("userID");
            WWWForm form = new WWWForm();
            form.AddField("IDPost", value);
            WWW www = new WWW(UserURL, form);
        }
    }
}
