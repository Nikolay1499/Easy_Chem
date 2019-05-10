using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mechanism : MonoBehaviour {
    public int max;
    public GameObject[] question;
    public int number;
    public GameObject wintext;
	void Start ()
    {
        number = Random.Range(0, max);
        question[number].SetActive(true);
    }
	public void NextQuestion()
    {
        question[number].SetActive(false);
            question[number] = question[max-1];
            max--;
        number = Random.Range(0, max);
        question[number].SetActive(true);
        if (max == 0)
        {
            question[number].SetActive(false);
            wintext.SetActive(true);
        }
    }
}
