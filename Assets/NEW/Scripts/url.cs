using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class url : MonoBehaviour
{
   public void OpenFacebook ()
    {
        Application.OpenURL("https://www.facebook.com/unicluster.face");
    }

    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/unicluster");
    }
}
