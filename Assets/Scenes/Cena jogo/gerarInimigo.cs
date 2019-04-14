using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerarInimigo : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            print("02");
            ScoreTextScript.coinAmount += 20;
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
