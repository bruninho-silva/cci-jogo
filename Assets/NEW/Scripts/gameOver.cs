using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{

    public GameObject GameOverUI;
    public bool gameover = false;

    // Start is called before the first frame update
    void Start()
    {
        GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            GameOverUI.SetActive(true);
            Time.timeScale = 0;
        }
        if (!gameover)
        {
            GameOverUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
