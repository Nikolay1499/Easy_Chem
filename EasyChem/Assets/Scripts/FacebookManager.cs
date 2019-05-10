using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;
using System.Collections;
using System.Collections.Generic;
using Facebook.MiniJSON;

public class FacebookManager : MonoBehaviour
{
    public GameObject user;
    AccessToken token;
    public Text idtext;
    public Button loginbutton;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;

    string UserURL = "http://easychem.comze.com/Login.php";

    private void Start()
    {
        if (!FB.IsInitialized)
        {
            FB.Init();
        }
        else {
            FB.ActivateApp();
        }
        DealWithFBMenus(FB.IsLoggedIn);
    }

    public void Login()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            FB.LogInWithReadPermissions(callback: OnLogIn);
        }
        else
        {
            StartCoroutine(NoInternet());
        }
    }
    IEnumerator NoInternet()
    {
        obj3.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        obj3.SetActive(false);
    }
    private void OnLogIn(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            loginbutton.enabled = false;
            token = AccessToken.CurrentAccessToken;
            PlayerPrefs.SetString("userID", token.UserId);
            PlayerPrefs.SetInt("FBLog", 1);
            WWWForm form = new WWWForm();
            form.AddField("IDPost", token.UserId);
            WWW www = new WWW(UserURL, form);
        }
        else
        {
            Debug.Log("Inable to log");
        }
        DealWithFBMenus(FB.IsLoggedIn);
    }
    void DealWithFBMenus(bool isLoggedIn)
    {
        if(isLoggedIn==true)
            loginbutton.enabled = false;
        FB.API("/me?fields=first_name", HttpMethod.GET, DisplayUsername);

    }

    void DisplayUsername(IResult result)
    {

        Text UserName = user.GetComponent<Text>();

        if (result.Error == null)
        {

            UserName.text = "Здравей," + result.ResultDictionary["first_name"];
            PlayerPrefs.SetString("FBName", UserName.text);
            obj4.SetActive(false);
            obj5.SetActive(true);

        }
        else {
            Debug.Log(result.Error);
        }
    }
    public void Share()
    {
        FB.ShareLink(contentTitle: "Google Page message",
            contentURL: new System.Uri("https://www.google.bg/"),
            contentDescription: "Link to Google",
            callback: OnShare);
    }

    private void OnShare(IShareResult result)
    {
        if (result.Cancelled|| string.IsNullOrEmpty(result.Error))
        {
            Debug.Log("Share link error");
        }
        else if (!string.IsNullOrEmpty(result.PostId))
        {
            Debug.Log(result.PostId);
        }
        else
        {
            Debug.Log("Share succeed");
        }
    }

    public void Loggingout()
    {
        FB.LogOut();
        loginbutton.enabled = true;
        idtext.text = "Вход";
    }
}

