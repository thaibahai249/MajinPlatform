using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{

    public static int redirectTolevel;
    public static int nextLevel;
    
    void Update()
    {
        if (redirectTolevel == 3)
        {
            SceneManager.LoadScene(redirectTolevel);
        }    
    }
}
