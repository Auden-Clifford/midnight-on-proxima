using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    [SerializeField] private Transform leftAttachTransform;
    [SerializeField] private Transform rightAttachTransform;

    /// <summary>
    /// Allosw the object to use different attach points based on which hand is grabbing it
    /// </summary>
    /// <param name="interactor"></param>
    /// <returns></returns>
    public override Transform GetAttachTransform(IXRInteractor interactor)
    {
        Transform i_attachTransform = null;

        if (interactor.transform.CompareTag("Left Hand"))
        {
            i_attachTransform = leftAttachTransform;
        }
        if (interactor.transform.CompareTag("Right Hand"))
        {
            i_attachTransform = rightAttachTransform;
        }
        return i_attachTransform != null ? i_attachTransform : base.GetAttachTransform(interactor);
    }
}
