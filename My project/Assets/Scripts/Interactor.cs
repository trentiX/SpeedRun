using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;

interface IInteractable {
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    public Image Crosshair;
  
    void Update() {
        if(Input.GetKeyDown(KeyCode.E)) {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if(Physics.Raycast(r, out RaycastHit hitInfo, InteractRange)) {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) {
                    interactObj.Interact();
                }
            }
        }

        Ray k = new Ray(InteractorSource.position, InteractorSource.forward);
        if(Physics.Raycast(k, out RaycastHit hitInfo1, InteractRange)) {
            if(hitInfo1.collider.gameObject.TryGetComponent(out IInteractable interactObj))
            {
                Crosshair.color = Color.white;
            }
        }
        else
        {
            Crosshair.color = Color.gray;
        }
    }
}
