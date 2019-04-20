using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public GameObject life01;
    public GameObject life02;
    public GameObject life03;
    public bool life2isGone;
    public bool life3isGone;

    // Start is called before the first frame update
    void Start()
    {
        life2isGone = false;
        life3isGone = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("inimigo")) { 
            if (life3isGone == false)
            {
                life03.transform.Translate(100f, 0f, 0f);
                life3isGone = true;
            }
            else if (life3isGone == true && life2isGone == false)
            {
                life02.transform.Translate(100f, 0f, 0f);
                life2isGone = true;
            }
            else if (life3isGone == true && life2isGone == true)
            {
                SceneManager.LoadScene("cena-menu");
            }
        }
    }

    // Atualização é chamada uma vez por quadro
    void Update()
    {
        
    }
}
