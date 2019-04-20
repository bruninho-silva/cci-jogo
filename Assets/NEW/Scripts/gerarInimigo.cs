using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerarInimigo : MonoBehaviour
{
    [Header("Renascer")]
    public Transform local;
    public Transform inimigo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            print("Entrou");
            ScoreTextScript.coinAmount -= 5;
            Destroy(gameObject);
            gerar();
        }
    }

    void gerar()
    {
        var enemyTransform = Instantiate(inimigo) as Transform;
        enemyTransform.position = local.transform.position;
    }
}
