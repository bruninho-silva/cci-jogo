using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swapSceneTime : MonoBehaviour
{
    [Header("Cenarios")]
    [SerializeField]
    public string digiteACena;
    [HideInInspector]
	public float tempo;

    void Update()
    {
        tempo +=Time.deltaTime;
		if(tempo >= 1.5){
            SceneManager.LoadScene(digiteACena);
        }
    }
}
