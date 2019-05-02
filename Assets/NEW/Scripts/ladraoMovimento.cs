using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladraoMovimento : MonoBehaviour
{

    [Header("Movimento")]
    public float distancia = 3;
    public float velocidade = 3;

    [Header("GameObject")]
    public Transform DetectaChao;
    public Transform inicioCP; //inicio do campo de visão 
    public Transform fimCP; //final do campo de visão 

    private bool olhandoParaDireita;
    private bool spot = false; //booleana para saber se o jogador esta dentro do campo de visão
    private Transform target; //alvo que o inimigo vai perseguir, nesse caso o jogador
    

    void Start()
    {
        // Inimigo ira olhar para Direita
        olhandoParaDireita = true;
    }

    // Atualização é chamada uma vez por quadro
    void FixedUpdate()
    {
        Patrulha();
        Raycasting();
        Persegue();
    }

    // Se estiver alguma parede na frente, irá retornar
    public void Patrulha()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(DetectaChao.position, Vector2.down, distancia);

        if (groundInfo.collider == false)
        {
            // Ira andar para Direita
            if (olhandoParaDireita == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                olhandoParaDireita = false;
            }
            // Ira andar para Esquerda
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                olhandoParaDireita = true;
            }
        }
    }

    // Campo de visão
    public void Raycasting()
    {
        Debug.DrawLine(inicioCP.position, fimCP.position, Color.green);
        spot = Physics2D.Linecast(inicioCP.position, fimCP.position, 1 << LayerMask.NameToLayer("player"));
    }

    // Caso encontre o Player, ira perseguir.
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
    }
}