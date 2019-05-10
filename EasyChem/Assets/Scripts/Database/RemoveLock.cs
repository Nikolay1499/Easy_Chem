using UnityEngine;
using System.Collections;

public class RemoveLock : MonoBehaviour {

    string item;
    string id;
    public GameObject obj;
    public string UserURL ;
    void Start()
    {
        StartCoroutine(Data());
    }
    IEnumerator Data()
    {
        id = PlayerPrefs.GetString("userID");
        WWWForm form = new WWWForm();
        form.AddField("IDPost", id);
        WWW itemsData = new WWW(UserURL, form);
        yield return itemsData;
        item = itemsData.text;
        if (item == "1") obj.SetActive(false);
    }
}
