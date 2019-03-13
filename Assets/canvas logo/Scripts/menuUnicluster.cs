using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuUnicluster : MonoBehaviour
{
	public float tempo;
       void Start()
    {
    
    }

     // Update is called once per frame
    void Update()
    {
        tempo +=Time.deltaTime;
		if(tempo >= 3){
			Application.LoadLevel("cena-logo-unip");
		}
    }
}
