using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TriggerArea : XRBaseInteractor
{
    private IXRInteractable currentInteractable = null;

    private void OnTriggerEnter(Collider other)
    {
        SetInteractable(other);
    }

    private void OnTriggerExit(Collider other)
    {
        ClearInteractable(other);
    }

    private void SetInteractable(Collider other)
    {
        if(TryGetInteractable(other, out IXRInteractable interactable))
        {
            if(currentInteractable == null)
            {
                currentInteractable = interactable;
            }
        }
    }

    private void ClearInteractable(Collider other)
    {
        if(TryGetInteractable(other, out IXRInteractable interactable))
        {
            if(currentInteractable == interactable)
            {
                currentInteractable = null;
            }
        }
    }

    private bool TryGetInteractable(Collider collider, out IXRInteractable interactable)
    {
        interactable = interactionManager.GetInteractableForCollider(collider);
        
        return interactable != null;
    }
    
    public override void GetValidTargets(List<IXRInteractable> targets)
    {
        targets.Clear();
        targets.Add(currentInteractable);
    }

    public override bool CanHover(IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable) && currentInteractable == interactable;
    }

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return false;
    }
}
