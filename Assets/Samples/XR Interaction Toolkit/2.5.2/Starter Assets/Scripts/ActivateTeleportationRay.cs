using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    [SerializeField] private GameObject jumpTeleportRay;
    [SerializeField] private InputActionProperty jumpActivate;

    // Update is called once per frame
    void Update()
    {
        Vector2 thumbstickValue = jumpActivate.action.ReadValue<Vector2>();
        jumpTeleportRay.SetActive(thumbstickValue.y < -0.5 && Mathf.Abs(thumbstickValue.x) < 0.5);
    }
}
