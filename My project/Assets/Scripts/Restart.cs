using System;
using System.Collections;
using System.Collections.Generic;
using Fragsurf.Movement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject gameCanvas;
    public GameObject menuCanvas;
    public PlayerAiming cameraHolder;
    public SurfCharacter surfCharacter;
    private Timer _timer;
    public BoxCollider secTrigger;

    private void Awake()
    {
        _timer = FindObjectOfType<Timer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            cameraHolder.enabled = true;
            surfCharacter.enabled = true;
            gameObject.transform.position = new Vector3(2.05f, 2, 35.91f);
            _timer.timerStarted = false;
            _timer.isTiming = false;
            secTrigger.isTrigger = true;
            gameCanvas.SetActive(true);
            menuCanvas.SetActive(false);
        }
    }
}
