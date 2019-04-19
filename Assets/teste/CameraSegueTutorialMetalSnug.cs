using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegueTutorialMetalSnug : MonoBehaviour
{

    public GameObject player;
    public float camVel = 0.25f;
    private bool seguePlayer;
    public Vector3 ultimoAlvoPos;
    public Vector3 velAtual;


    // Start is called before the first frame update
    void Start()
    {
        seguePlayer = true;
        ultimoAlvoPos = player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (seguePlayer)
        {
            if (player.transform.position.x >= transform.position.x)
            {
                Vector3 novaCamPos = Vector3.SmoothDamp(transform.position, player.transform.position, ref velAtual, camVel);
                transform.position = new Vector3(novaCamPos.x, novaCamPos.y, transform.position.z);
                ultimoAlvoPos = player.transform.position;
            }
        }
    }
}
