using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InventoryStack: MonoBehaviour
{
    public Stack<GameObject> items;

    // Start is called before the first frame update
    void Start()
    {
        items = new Stack<GameObject>();
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
        print("selected backpack");
        if(items.Count > 0)
        {
            GameObject item = items.Pop();
            item.SetActive(true);
            args.interactor.StartManualInteraction(item.GetComponent<XRGrabInteractable>());
        }
    }
}
