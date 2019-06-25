using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swapScene : MonoBehaviour
{

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void CenaMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("cena-menu");
    }
    public void CenaRank()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("cena-rank");
    }
    public void CenaCreditos()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("cena-creditos");
    }
    public void CenaNome()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("cena-nome");
    }
    public void CenaJogo()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("policeAndThief");
    }
    public void CenaTutorial()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("cena-tutorial");
    }
    public void Sair()
    {
        Application.Quit();
    }
}