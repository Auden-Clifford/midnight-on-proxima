using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaserCutter : MonoBehaviour
{
    [SerializeField] private Transform rayOriginPoint;
    [SerializeField] private float damage;
    [SerializeField] private float maxDistance;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private GameObject impactEffect;
    private bool active;

    public void Activate()
    {
        active = true;
    }

    public void Deactivate()
    {
        active = false;
        lineRenderer.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(active)
        {
            RaycastHit hit;

            // cast a ray and check for a hit
            if (Physics.Raycast(rayOriginPoint.position, rayOriginPoint.forward, out hit, maxDistance))
            {
                lineRenderer.enabled = true;

                // check if threre is a rigidbody component
                Rigidbody targetRigidbody = hit.collider.GetComponent<Rigidbody>();
                if (targetRigidbody != null)
                {
                    // add force to the hit object
                    targetRigidbody.AddForceAtPosition(rayOriginPoint.forward * damage, hit.point, ForceMode.Impulse);
                }

                // draw the laser to the point hit
                lineRenderer.SetPosition(0, rayOriginPoint.position);
                lineRenderer.SetPosition(1, hit.point);
                

                // instantiate an impact effect at point of impact
                Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));

            }
            else
            {
                lineRenderer.enabled = false;
            }
        }
    }
}
