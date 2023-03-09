using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level001 : MonoBehaviour
{
    public GameObject fadeIn;


    void Start()
    {
        RedirectToLevel.redirectTolevel = 3;
        RedirectToLevel.nextLevel = 5;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
