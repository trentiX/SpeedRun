using System;
using System.Collections;
using System.Collections.Generic;
using Fragsurf.Movement;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    public GameObject gameCanvas;
    public GameObject menuCanvas;
    public GameObject start;
    public GameObject sleep;
    public PlayerAiming cameraHolder;
    public SurfCharacter surfCharacter;
    private Timer _timer;

    private void Awake()
    {
        _timer = FindObjectOfType<Timer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Убедитесь, что у объекта-триггера есть тег "Player"
        {
            cameraHolder.enabled = false;
            surfCharacter.enabled = false;
            _timer.newRecord();
            _timer.isTiming = false;
            menuCanvas.SetActive(true);
            start.SetActive(false);
            gameCanvas.SetActive(false);
            sleep.SetActive(true);
        }
    }
}
