using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apagarLuz : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("luz"))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
