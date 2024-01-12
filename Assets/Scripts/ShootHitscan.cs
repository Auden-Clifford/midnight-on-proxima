using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootHitscan : MonoBehaviour
{
    [SerializeField] private Transform rayOriginPoint;
    [SerializeField] private float force;
    [SerializeField] private float maxDistance;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private GameObject impactEffect;

   public void Fire()
   {
        RaycastHit hit;

        // cast a ray and chanc for a hit
        if(Physics.Raycast(rayOriginPoint.position, rayOriginPoint.forward, out hit, maxDistance))
        {
            // check if threre is a rigidbody component
            Rigidbody targetRigidbody = hit.collider.GetComponent<Rigidbody>();
            if(targetRigidbody != null)
            {
                // add force to the hit object
                targetRigidbody.AddForceAtPosition(rayOriginPoint.forward * force, hit.point, ForceMode.Impulse);
            }

            // draw the bullet trail to the point hit
            StartCoroutine(DrawShot(rayOriginPoint.position, hit.point));

            // instantiate an impact effect at point of impact
            Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));

        }
        // if nothing was hit draw a bullet trail to the max distance
        else
        {
            StartCoroutine(DrawShot(rayOriginPoint.position, rayOriginPoint.position + rayOriginPoint.forward * maxDistance));
        }
   }

    private IEnumerator DrawShot(Vector3 start, Vector3 end)
    {
        lineRenderer.SetPosition(0, start);
        lineRenderer.SetPosition(1, end);
        lineRenderer.enabled = true;

        // wait a short time then hide again
        yield return new WaitForSeconds(0.01f);

        lineRenderer.enabled = false;
    }

}
