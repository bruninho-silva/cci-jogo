using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody2D rb;
    private Transform tr;
    private Animation an;
    public Transform verificarChao;
    public Transform verificarParede;

    private bool estaNaParede;
    private bool estaNoChao;
    private bool viradaParaDireita;

    public float velocidade;
    public float raioValidaChao;
    public float raioValidaParede;

    public LayerMask solido;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        an = GetComponent<Animation>();

        viradaParaDireita = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        EnemyMovements();
    }

    void EnemyMovements()
    {
        estaNoChao = Physics2D.OverlapCircle (verificarChao.position,raioValidaChao,solido);
        estaNaParede = Physics2D.OverlapCircle (verificarParede.position, raioValidaParede, solido);

        if(!estaNoChao || estaNaParede)
        {
            Flip();
        }
        if (estaNoChao)
        {
            rb.velocity = new Vector2(velocidade,rb.velocity.y);
        }
    }

    void Flip()
    {
        viradaParaDireita = !viradaParaDireita;
        tr.localScale = new Vector2(-tr.localScale.x, tr.localScale.y);
        velocidade *= -1;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(verificarChao.position, raioValidaChao);
        Gizmos.DrawWireSphere(verificarParede.position,raioValidaParede);
    }
}
