using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RestartTextAnim : MonoBehaviour
{
    public TextMeshProUGUI restartText;
    
    private void OnEnable()
    {
        StartCoroutine(Restartanim());
    }
    private IEnumerator Restartanim()
    {
        restartText.color = new Color(255,255,255,255);
        yield return new WaitForSeconds(0.5f);
        restartText.color = new Color(255,255,255,0);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Restartanim());
    }
}
