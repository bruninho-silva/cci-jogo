using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class menuRecord : MonoBehaviour
{

    public Text record;

    // Start is called before the first frame update
    void Start()
    {
        record.text = PlayerPrefs.GetInt("record").ToString();
    }

}
