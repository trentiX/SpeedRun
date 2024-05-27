using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float elapsedTime = 0f; // Прошедшее время
    public TextMeshProUGUI timerText; // UI Text для отображения времени
    public TextMeshProUGUI recordText;
    public TextMeshProUGUI finalTimerText;
    
    public bool isTiming = false; // Флаг для отслеживания состояния таймера
    public bool timerStarted = false;
    private float record = 1000f;

    void Start()
    {
        UpdateTimerText();
    }

    void Update()
    {
        if (isTiming)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int tenths = Mathf.FloorToInt((elapsedTime * 10) % 10);

        timerText.text = string.Format("{0:00}:{1:00}.{2:0}", minutes, seconds, tenths);
        finalTimerText.text = "YOUR TIME: " + string.Format("{0:00}:{1:00}.{2:0}", minutes, seconds, tenths);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Убедитесь, что у объекта-триггера есть тег "Player"
        {
            if (timerStarted)
            {
                newRecord();
                timerStarted = false;
                isTiming = false;
            }
            else
            {
                timerStarted = true;
                isTiming = true;
                elapsedTime = 0f; // Сброс времени, если необходимо
            }
        }
    }

    public void newRecord()
    {
        if (elapsedTime < record)
        {
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            int tenths = Mathf.FloorToInt((elapsedTime * 10) % 10);

            recordText.text = "RECORD: " + string.Format("{0:00}:{1:00}.{2:0}", minutes, seconds, tenths);
            record = elapsedTime;
        }
    }
}
