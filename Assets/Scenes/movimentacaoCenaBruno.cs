using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaoCenaBruno : MonoBehaviour
{
    [HideInInspector]
    private int direcao = 0;

    [SerializeField]
    public int velocidade = 6;
    // Animator = Responsavel por Habilitar ou Desabilidar a movimentação do Personagem.
    public Animator anins;
    // Flip = Resposanvel para inverter a posição do Personagem.
    public SpriteRenderer posicao_inverti;

    //Variaveis responsaveis pelo pulo do personagem
    public float forca = 150f;
    public Rigidbody2D police;
    public bool liberaPulo = false;
    public bool cliqueiNoBotaoPular = false;


    // Atualização é chamada uma vez por quadro
    void Update()
    {
        mover();

        if (liberaPulo && cliqueiNoBotaoPular)
        {
            police.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
            liberaPulo = false;
            cliqueiNoBotaoPular = false;
        }


    }

    //Metodos do pulo do personagem
    public void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao"))
        {
            liberaPulo = true;
        }
    }

    public void OnCollisionExit(Collision outro)
    {
        if (outro.gameObject.CompareTag("chao"))
        {
            liberaPulo = false;
        }
    }

    public void ativaPulo()
    {
        cliqueiNoBotaoPular = true;
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
