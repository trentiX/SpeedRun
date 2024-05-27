using System;
using System.Collections;
using System.Collections.Generic;
using Fragsurf.Movement;
using TMPro;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    public TextMeshProUGUI startText;
    public GameObject menuCanvas;
    public GameObject gameCanvas;
    public PlayerAiming cameraHolder;
    public SurfCharacter surfCharacter;
    public GameObject sleep;

    private void Start()
    {
        gameCanvas.SetActive(false);
        sleep.SetActive(false);
        menuCanvas.SetActive(true);
        startText.enabled = true;
        cameraHolder.enabled = false;
        surfCharacter.enabled = false;
        StartCoroutine(anim());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    private IEnumerator anim()
    {
        startText.color = new Color(255,255,255,255);
        yield return new WaitForSeconds(0.5f);
        startText.color = new Color(255,255,255,0);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(anim());
    }

    private void StartGame()
    {
        StopCoroutine(anim());
        gameCanvas.SetActive(true);
        cameraHolder.enabled = true;
        surfCharacter.enabled = true;
        menuCanvas.SetActive(false);
        startText.enabled = false;
    }
}
