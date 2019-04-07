using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao1 : MonoBehaviour
{
    [HideInInspector]
    private int direcao = 0;

    [SerializeField]
    public int velocidade = 6;
    // Animator = Responsavel por Habilitar ou Desabilidar a movimentação do Personagem.
    public Animator anins;
    // Flip = Resposanvel para inverter a posição do Personagem.
    public SpriteRenderer posicao_inverti;

    // Atualização é chamada uma vez por quadro
    void Update()
    {
        mover();
    }

    // Ira habilitar Andar para DIRETA
    public void direita(){
        anins.SetBool("Parado", false);
        anins.SetBool("Andando", true);
        posicao_inverti.flipX = false;
        direcao = velocidade;
    }

    // Ira habilitar Andar para ESQUERDA
    public void esquerda(){
        anins.SetBool("Parado", false);
        anins.SetBool("Andando", true);
        posicao_inverti.flipX = true;
        direcao = -velocidade;
    }

    // Ira desabilitar o Andar
    public void parar(){
        direcao = 0;
        anins.SetBool("Parado", true);
        anins.SetBool("Andando", false);
    }

    // De acordo com a direcao, este valor sera atribuido no x, fazendo o personagem andar.
    public void mover(){
        transform.Translate(direcao * Time.deltaTime,0,0);
    }
}
