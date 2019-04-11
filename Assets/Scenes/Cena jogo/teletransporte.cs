using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletransporte : MonoBehaviour
{

    [SerializeField]
    public GameObject button;

    public GameObject personagem;
    public GameObject portalAtual;

    public bool buttonClicado = false;
    public bool portaAberta = false;

    public GameObject[] teste;
    int index;

    private void OnTriggerEnter2D(Collider2D atual)
    {
        print("entrou");
        if (atual.gameObject.CompareTag("player"))
        {

            index = Random.Range(0, teste.Length);
            portalAtual = teste[index];

            print("---------ENTROU NO COMPARE");
            portaAberta = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        portaAberta = false;
    }

    public void ativaPorta()
    {
        if (portaAberta == true)
        {
            buttonClicado = true;
        }

    }

    // Atualização é chamada uma vez por quadro
    void Update()
    {
        if (buttonClicado == true && portaAberta == true)
        {
            print("---------ENTROU MOVIMENTAR");
            personagem.transform.position = portalAtual.transform.position;
            buttonClicado = false;
            portaAberta = false;
        }

    }
}

