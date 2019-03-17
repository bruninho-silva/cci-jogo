using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public float a;
    public float b;

    public float screemwidth;
    public float screemheight;

    // Start is called before the first frame update
    void Start()
    {
        a = transform.localScale.x;
        b = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        screemwidth = Screen.width;
        screemheight = Screen.height;

        transform.localScale = new Vector3((a * screemwidth / screemheight), transform.localScale.y, transform.localScale.x);
    }

    void Awake()
    {
        
    }
}
