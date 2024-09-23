using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InventoryStack: MonoBehaviour
{
    private Stack<GameObject> items;
    [SerializeField] private XRInteractionManager interactionManager;

    // Start is called before the first frame update
    void Start()
    {
        items = new Stack<GameObject>();
        interactionManager = FindFirstObjectByType<XRInteractionManager>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        print("object entered backpack");
        if(other.gameObject.CompareTag("Salvage"))
        {
            XRGrabInteractable interactable = other.gameObject.GetComponent<XRGrabInteractable>();
            if (interactable != null && !interactable.isSelected)
            {
                AddItem(other.gameObject);
            }
        }
    }
    */

    /// <summary>
    /// Adds a given item to the inventory
    /// </summary>
    /// <param name="item"></param>
    public void AddItem(GameObject item)
    {
        if(item.tag == "Salvage")
        {
            item.SetActive(false);
            items.Push(item);
            print("added item");
        }
    }

    public void RemoveItem(SelectEnterEventArgs args)
    {
        //unselect the backpack
        interactionManager.SelectExit(args.interactor, args.interactable);
        print("selected backpack");
        if(items.Count > 0)
        {
            GameObject item = items.Pop();
            item.SetActive(true);
            interactionManager.SelectEnter(args.interactor, item.GetComponent<XRGrabInteractable>());
            //args.interactor.StartManualInteraction(item.GetComponent<XRGrabInteractable>());
        }
    }
}
