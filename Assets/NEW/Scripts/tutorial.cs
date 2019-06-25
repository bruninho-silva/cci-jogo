using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tutorial01;
    public GameObject tutorial02;
    public GameObject tutorial03;
    public GameObject tutorial04;

    /*private bool paused = false;*/

    // Start is called before the first frame update
    void Start()
    {
        tutorial01.SetActive(true);
        tutorial02.SetActive(false);
        tutorial03.SetActive(false);
        tutorial04.SetActive(false);
    }

    public void proximo01()
    {
        tutorial01.SetActive(false);
        tutorial02.SetActive(true);
    }
    public void proximo02()
    {
        tutorial02.SetActive(false);
        tutorial03.SetActive(true);
    }
    public void proximo03()
    {
        tutorial03.SetActive(false);
        tutorial04.SetActive(true);
    }
    public void proximo04()
    {
        SceneManager.LoadScene("policeAndThief");
    }
}
