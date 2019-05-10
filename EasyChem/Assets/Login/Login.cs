using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Login : MonoBehaviour {
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public GameObject popup;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public InputField inputEmail;
    public InputField inputPassword;
    public Text correct;
    public Text name;
    //public Text shortpass;
    string UserURL = "http://easychem.comze.com/InsertUserTest.php";
    public void Loging()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            StartCoroutine(CreateUser());
        }
        else
        {
            StartCoroutine(NoInternet());
        }
    }
	//WWWForm form = new WWWForm();
        IEnumerator CreateUser()
    {
        WWWForm form = new WWWForm();
        PlayerPrefs.SetString("userID", inputEmail.text);
        if (inputPassword.text == "" || inputEmail.text == "") correct.text = "Невалиден имейл или парола";
        else {
            form.AddField("PasswordPost", inputPassword.text);
            form.AddField("NamePost", inputEmail.text);
            WWW www = new WWW(UserURL, form);
            yield return www;
            if (www.text == "Login successful")
            {
                correct.text = "";
                popup.SetActive(true);
                button1.enabled = false;
                button2.enabled = false;
                button3.enabled = false;
                button4.enabled = false;
                yield return new WaitForSecondsRealtime(2);
                PlayerPrefs.SetInt("Logged", 1);
                popup.SetActive(false);
                obj1.SetActive(false);
                obj2.SetActive(true);
                obj4.SetActive(true);
                name.text = PlayerPrefs.GetString("userID");
            }
            else
            {
                correct.text = www.text;
                //Debug.Log(www.text);
            }
        }
    }
    IEnumerator NoInternet()
    {
        obj3.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        obj3.SetActive(false);
    }
}
