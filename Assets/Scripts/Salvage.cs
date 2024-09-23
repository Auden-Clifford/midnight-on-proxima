using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Salvage : MonoBehaviour
{
    [SerializeField] private float value;
    [SerializeField] private XRGrabInteractable interactableComponent;
    private InventoryStack trackedInventory;

    private void OnTriggerEnter(Collider other)
    {
        // only add the object to the inventory if it is being held and the trigger has an inventory
        if(interactableComponent.isSelected && other.gameObject.GetComponent<InventoryStack>() != null)
        {
            trackedInventory = other.gameObject.GetComponent<InventoryStack>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // only remove the inventory if the trigger being exited is the inventory
        if(trackedInventory != null && other.gameObject.GetComponent<InventoryStack>() == trackedInventory)
        {
            trackedInventory = null;
        }
    }

    /// <summary>
    /// Checks if the item has a valid inventory to enter and if so, stores itself in that inventory
    /// </summary>
    public void CheckStoreItem()
    {
        if(trackedInventory != null)
        {
            trackedInventory.AddItem(gameObject);
        }
    }

    /*
    public void SpecialDeselect(SelectExitEventArgs args)
    {
        print("release");
        args.interactor.EndManualInteraction();
    }

    public void TriggerTest()
    {
        print("pew pew");
    }
    */
}
