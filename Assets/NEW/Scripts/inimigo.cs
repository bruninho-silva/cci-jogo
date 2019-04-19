using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public Transform DetectaChao;
    public float distancia = 3;
    public bool olhandoParaDireita;
    public float velocidadeNormal;
    public float velocidade = 3;

    public bool spot = false; //booleana para saber se o jogador esta dentro do campo de visão
    public Transform target; //alvo que o inimigo vai perseguir, nesse caso o jogador
    public Transform inicioCP; //inicio do campo de visão 
    public Transform fimCP; //final do campo de visão 

    void Start()
    {
        // Inimigo ira olhar para Direita
        olhandoParaDireita = true;
    }

    // Atualização é chamada uma vez por quadro
    void Update()
    {
        Patrulha();
        Raycasting();
        Persegue();
    }

    // Se estiver alguma parede na frente, irá retornar
    public void Patrulha()
    {
        transform.Translate(Vector2.right * velocidadeNormal * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(DetectaChao.position, Vector2.down, distancia);

        if (groundInfo.collider == false)
        {
            if (olhandoParaDireita == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                olhandoParaDireita = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                olhandoParaDireita = true;
            }
        }
    }

    public void Raycasting()
    {
        Debug.DrawLine(inicioCP.position, fimCP.position, Color.green);
        spot = Physics2D.Linecast(inicioCP.position, fimCP.position, 1 << LayerMask.NameToLayer("player"));
    }

    public void Persegue()
    {
        if (spot == true && olhandoParaDireita == true)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            olhandoParaDireita = false;
        }
        else if (spot == true && olhandoParaDireita == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            olhandoParaDireita = true;
        }
        else if (spot == false)
        {
            velocidadeNormal = velocidade;
        }
    }
}