using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuUnip : MonoBehaviour
{
	public float tempo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           tempo +=Time.deltaTime;
		if(tempo >= 5){
			Application.LoadLevel("cena-menu");
		}
    }
}
