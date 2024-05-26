using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float elapsedTime = 0f; // Прошедшее время
    public TextMeshProUGUI timerText; // UI Text для отображения времени

    void Start()
    {
        UpdateTimerText();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int tenths = Mathf.FloorToInt((elapsedTime * 10) % 10);

        timerText.text = string.Format("{0:00}:{1:00}.{2:0}", minutes, seconds, tenths);
    }
}
