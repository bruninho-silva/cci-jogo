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
    public bool playerPortaAberta = false;
    public bool ladraoPortaAberta = false;
    public bool spot = false;

    public GameObject[] teste;
    public int index;

    public Transform visaoInicio; //inicio do campo de visão 
    public Transform visaoFim; //final do campo de visão 

    public void OnTriggerEnter2D(Collider2D atual)
    {
        if (atual.gameObject.CompareTag("player"))
        {

            index = Random.Range(0, teste.Length);
            portalAtual = teste[index];

            playerPortaAberta = true;
        }
        else

        //Physics2D.Linecast(atual.transform.position, atual.transform.position, 1 << LayerMask.NameToLayer("ladrao"))
        if (atual.gameObject.CompareTag("ladrao"))
        {
            index = Random.Range(0, teste.Length);
            portalAtual = teste[index];

            ladraoPortaAberta = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerPortaAberta = false;
        ladraoPortaAberta = false;
    }

    public void ativaPorta()
    {
        if (playerPortaAberta == true)
        {
            buttonClicado = true;
        }

    }

    // Atualização é chamada uma vez por quadro
    void Update()
    {

        GameObject ladrao = GameObject.FindGameObjectWithTag("ladrao");

        if (buttonClicado == true && playerPortaAberta == true)
        {
            personagem.transform.position = portalAtual.transform.position;
            buttonClicado = false;
            playerPortaAberta = false;
        }
        else

        if (ladraoPortaAberta == true && spot == true)
        {
            ladrao.transform.position = portalAtual.transform.position;
            ladraoPortaAberta = false;
        }

        Debug.DrawLine(visaoInicio.position, visaoFim.position, Color.red);
        spot = Physics2D.Linecast(visaoInicio.position, visaoFim.position, 1 << LayerMask.NameToLayer("player"));

    }
}

