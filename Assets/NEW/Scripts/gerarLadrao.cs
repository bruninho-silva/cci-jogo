using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerarLadrao : MonoBehaviour
{

    public Transform enemy;
    //public Transform regenera;
    public Transform[] regeneraAleatorio;
    private Transform regenera;
    public int index;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ladrao = GameObject.FindGameObjectWithTag("ladrao");

        if (collision.gameObject.tag == "ladrao")
        {

            index = Random.Range(0, regeneraAleatorio.Length);
            regenera = regeneraAleatorio[index];

            ScoreTextScript.coinAmount += 10;
            Destroy(ladrao);
            gerar();
        }
    }

    void gerar()
    {
        var enemyTransform = Instantiate(enemy) as Transform;
        enemyTransform.position = regenera.transform.position;

    }

}
