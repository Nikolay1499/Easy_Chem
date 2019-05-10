using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextRemove : MonoBehaviour {
    public InputField[] field1;
    public Text text1;
    public Text text2;
    public Text text3;
    public Button button1;
    public Button button2;
    public Button button3;
    private int match;
    public GameObject obj1;
    public GameObject obj2;
    void Update()
    {
        match = PlayerPrefs.GetInt("Logged");
        if(text3.text=="Log in" && match == 1)
        {
            button1.enabled = false;
            text3.text = "Hello " +PlayerPrefs.GetString("email");
        }
    }
    public void Change()
    {
        if (obj1.activeInHierarchy == true) text2.text = "";
        if (obj2.activeInHierarchy == true) text1.text = "";
        for(int i=0;i<5;i++)
        {
            field1[i].text = "";
        }
    }
    public void Logout()
    {
        if(text3.text!="Log in")
        {
            text3.text = "Log in";
            button1.enabled = true;
            button2.enabled = true;
            button3.enabled = true;
            PlayerPrefs.SetInt("Logged", 0);
            PlayerPrefs.DeleteKey("email");
        }
    }
}
