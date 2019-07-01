using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public static int coinAmount;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = coinAmount.ToString();
        PlayerPrefs.SetString("pontos", text.text);
    }
}
