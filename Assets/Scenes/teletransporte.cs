using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletransporte : MonoBehaviour
{

    [SerializeField]
    public GameObject button;

    public GameObject personagem;
    public GameObject currentPoint;

    public bool abrir = false;

    public GameObject[] teste;
    int index;


    // Update is called once per frame
    void Update()
    {
        index = Random.Range(0, teste.Length);
        currentPoint = teste[index];
    }

    void OnCollisionEnter2D(Collision2D porta)
    {

        if (porta.gameObject.CompareTag("porta"))
        {
            personagem.transform.position = currentPoint.transform.position;
            abrir = true;
        } else
        {
            abrir = false;
        }
    }

    void OnGUI()
    {
        if (Event.current.button == 1)
        {
            if (Event.current.type == EventType.MouseDown)
            {
                print("funciona");
            }
        }
    }

}

