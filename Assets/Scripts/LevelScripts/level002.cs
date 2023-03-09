using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level002 : MonoBehaviour
{
    public GameObject fadeIn;


    void Start()
    {
        RedirectToLevel.redirectTolevel = 5;
        RedirectToLevel.nextLevel = 1;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
