using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IhaveFeeling : MonoBehaviour
{
    public TextMeshProUGUI dialog;

    private void OnEnable()
    {
        StartCoroutine(anim());
    }

    private IEnumerator anim()
    {
        dialog.color = new Color(255,255,255,255);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,0);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,255);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,0);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,255);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,0);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,255);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,0);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,255);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,0);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,255);
        yield return new WaitForSeconds(0.5f);
        dialog.color = new Color(255,255,255,0);
        yield return new WaitForSeconds(0.5f);
        StopCoroutine(anim());
    }
}
