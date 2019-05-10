using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Register : MonoBehaviour { 
    public GameObject a;
    public GameObject b;
    public GameObject popup;
    public GameObject obj3;
    public Button button1;
    public Button button2;
	public InputField inputEmail;
    public InputField inputPassword;
    public InputField inputConfirm;
    public Text correct;
    //public Text shortpass;
    string UserURL = "http://easychem.comze.com/LoginTest.php";
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
        if (inputPassword.text.Length < 8) correct.text = "Паролата е твърде къса";
        else if (inputConfirm.text != inputPassword.text) correct.text = "Паролите не съвпадат";
        else {
            form.AddField("PasswordPost", inputPassword.text);
            form.AddField("NamePost", inputEmail.text);
            WWW www = new WWW(UserURL, form);
            yield return www;
            if(www.text== "User successfully created")
            {
                popup.SetActive(true);
                correct.text = "";
                inputEmail.text = "";
                inputPassword.text = "";
                inputConfirm.text = "";
                button1.enabled = false;
                button2.enabled = false;
                yield return new WaitForSecondsRealtime(2);
                popup.SetActive(false);
                button1.enabled = true;
                button2.enabled = true;
                a.SetActive(false);
                b.SetActive(true);
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
