using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int coinAmount = 0;

    public Text recordGameOver;
    public Text pontos;
    public Text pontosGameOver;

    // Start is called before the first frame update
    void Start()
    {
        coinAmount = 0;
    }

    void Update()
    {
        pontos.text = coinAmount.ToString();
        pontosGameOver.text = coinAmount.ToString();

        recordGameOver.text = PlayerPrefs.GetInt("record").ToString();

        if (PlayerPrefs.GetInt("record") < coinAmount)
        {
            PlayerPrefs.SetInt("record", coinAmount);
        }
    }
}
