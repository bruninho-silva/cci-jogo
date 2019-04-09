using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletra : MonoBehaviour
{

    public GameObject off;
    public GameObject on;

    public bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = off.GetComponent<SpriteRenderer>().sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = on.GetComponent<SpriteRenderer>().sprite;
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
