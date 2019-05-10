using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    float timeLeft = 30.0f;
    public Text text;
    public GameObject text2;
    void Update()
    {
        if (timeLeft > 0.0f)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            timeLeft = 0.0f;
        }
        text.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            text2.SetActive(true);
        }
    }
}
