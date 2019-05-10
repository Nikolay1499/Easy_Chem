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
    public Button button4; 
    public GameObject obj1;
    public GameObject obj2;
    void Start()
    {
        if (PlayerPrefs.GetInt("FBLog") == 1)
        {
            button1.enabled = false;
            text3.text = "" + PlayerPrefs.GetString("FBName");
        }
        else if (PlayerPrefs.GetString("userID") != "") {
            button1.enabled = false;
            text3.text = PlayerPrefs.GetString("userID");
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
        if(text3.text!="Вход")
        {
            text3.text = "Вход";
            button1.enabled = true;
            button2.enabled = true;
            button3.enabled = true;
            button4.enabled = true;
            PlayerPrefs.SetInt("Logged", 0);
            PlayerPrefs.DeleteKey("userID");
            PlayerPrefs.DeleteKey("FBLog");
            PlayerPrefs.DeleteKey("FBName");
        }
    }
}
