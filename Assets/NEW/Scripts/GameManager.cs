using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int coinAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreTextScript.coinAmount = 0;
        PlayerPrefs.SetString("pontos", coinAmount.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
