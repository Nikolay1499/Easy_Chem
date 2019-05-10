using UnityEngine;
using System.Collections;

public class ReceiveData1 : MonoBehaviour
{
    string item;
    string id;
    public GameObject obj;
    string UserURL = "http://easychem.comze.com/ItemsData.php";
    void Start()
    {
        StartCoroutine(Data());
    }
    IEnumerator Data()
    {
        id = PlayerPrefs.GetString("userID");
        WWWForm form = new WWWForm();
        form.AddField("userID", id);
        WWW itemsData = new WWW(UserURL, form);
        yield return itemsData;
        item = itemsData.text;
        if (item == "1") obj.SetActive(false);
    }
}