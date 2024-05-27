using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour,IInteractable
{
    public AudioSource piano;

    public void Interact()
    {
        piano.Play();
    }
}
