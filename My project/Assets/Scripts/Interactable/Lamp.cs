using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour, IInteractable
{
    public Light lampLight;
    private bool turnedOn = false;
    public void Interact()
    {
        if (turnedOn)
        {
            lampLight.intensity = 0;
            turnedOn = false;
        }

        else if (!turnedOn)
        {
            lampLight.intensity = 0.4f;
            turnedOn = true;
        }
    }
}
