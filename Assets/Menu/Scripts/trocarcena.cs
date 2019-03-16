using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocarcena : MonoBehaviour
{
    public void CenaMenu()
    {
        SceneManager.LoadScene("cena-menu");
    }
    public void CenaRank()
    {
        SceneManager.LoadScene("cena-rank");
    }
    public void CenaCreditos()
    {
        SceneManager.LoadScene("cena-creditos");
    }
    public void CenaNome()
    {
        SceneManager.LoadScene("cena-nome");
    }
}