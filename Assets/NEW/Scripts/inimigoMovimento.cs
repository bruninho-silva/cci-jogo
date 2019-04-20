using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoMovimento : MonoBehaviour
{
    [Header("Movimento")]
    public float distancia = 3;
    public float velocidade = 3;

    [Header("GameObject")]
    public Transform DetectaChao;

    private bool olhandoParaDireita;

    void Start()
    {
        olhandoParaDireita = true;
    }

    // Atualização é chamada uma vez por quadro
    void Update()
    {
        Patrulha();
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
}