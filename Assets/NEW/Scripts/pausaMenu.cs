using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausaMenu : MonoBehaviour
{

    public GameObject PausaUI;

    private bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        PausaUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (paused)
        {
            PausaUI.SetActive(true);
            Time.timeScale = 0;
        }

        if(!paused)
        {
            PausaUI.SetActive(false);

        }
    }

    public void AtivarMenu()
    {
        paused = !paused;
    }
}