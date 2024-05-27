using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coke : MonoBehaviour, IInteractable
{
    public AudioSource coke;

    public void Interact()
    {
        coke.Play();
    }
}
