using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecTrigger : MonoBehaviour
{
    public BoxCollider secTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Убедитесь, что у объекта-триггера есть тег "Player"
        {
            secTrigger.isTrigger = false;
        }
    }
}
