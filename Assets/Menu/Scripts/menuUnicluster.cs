using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuUnicluster : MonoBehaviour
{
	public float tempo;
    public string cena;

       void Start()
    {
    
    }

     // Update is called once per frame
    void Update()
    {
        tempo +=Time.deltaTime;
		if(tempo >= 3){
            SceneManager.LoadScene(cena);
        }
    }
}
