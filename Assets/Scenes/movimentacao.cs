using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    [SerializeField]
    private int direcao = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mover();
    }
public void direita(){
direcao = 2;
}

public void esquerda(){
direcao = -2;
}

public void parar(){
direcao = 0;
}

public void mover(){
    transform.Translate(direcao * Time.deltaTime,0,0);
}
}
