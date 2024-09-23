using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ForceDropNonTool : MonoBehaviour
{
    [SerializeField] private XRBaseInteractor interactor;
    [SerializeField] private InputActionProperty selectAction;
    [SerializeField] private XRInteractionManager interactorManager;

    private void Update()
    {
        /*
        if (selectAction.action.ReadValue<float>() == 0 && interactor.isPerformingManualInteraction)
        {
            if (interactor.selectTarget != null && interactor.selectTarget.gameObject.tag != "Tool")
            {
                interactor.EndManualInteraction();
                //interactor.allowSelect = false;
                //interactor.selectExited.Invoke(new SelectExitEventArgs());
                interactorManager.SelectExit(interactor, interactor.selectTarget);
            }
        }
        */
    }

    public void TestSelect()
    {
        //interactor.allowSelect = true;
        //print("selecting");
    }
}
