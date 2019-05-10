using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckScript : MonoBehaviour {
    public GameObject correct;
    public GameObject wrong;
    public InputField info;
    public GameObject textcorrect;
    public GameObject nextb;
    public GameObject retry;
    public string answear;
    public string answear2;
    public void Check()
    {
        if (info.text == answear||info.text==answear2)
        {
            correct.SetActive(true);
            textcorrect.SetActive(false);
            correct.SetActive(false);
            textcorrect.SetActive(true);
            nextb.SetActive(true);
        }
        else
        {
            wrong.SetActive(true);
            correct.SetActive(false);
            retry.SetActive(true);
        }
    }
    public void NextQuestion()
    {
        correct.SetActive(false);
        textcorrect.SetActive(true);
        correct.SetActive(true);
        textcorrect.SetActive(false);
        nextb.SetActive(false);
    }
    public void Retry()
    {
        wrong.SetActive(false);
        correct.SetActive(true);
        retry.SetActive(false);

    }
}
