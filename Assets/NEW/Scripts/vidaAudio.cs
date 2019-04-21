using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaAudio : MonoBehaviour
{

    private float tempo = 1.5f;

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;

        if (tempo <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
