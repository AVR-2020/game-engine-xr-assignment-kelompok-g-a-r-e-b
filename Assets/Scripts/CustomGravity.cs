using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    public float PullRadius; // Radius to pull
    public float GravitationalPull; // Pull force
    public float MinRadius; // Minimum distance to pull from
    public float DistanceMultiplier; // Factor by which the distance affects force

    public LayerMask LayersToPull;

    Plane plane;
    Vector3 normal;
    MeshFilter filter;

    void Start()
    {
        //plane = new Plane();
        //filter = this.GetComponent<MeshFilter>();
    }

    // Function that runs on every physics frame
    void FixedUpdate()
    {
        Plane plane = new Plane(transform.up, transform.position);
        Collider[] colliders = Physics.OverlapSphere(transform.position, PullRadius, LayersToPull);
        //normal = filter.mesh.normals[0];

        foreach (var collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            if (rb == null) continue; // Can only pull objects with Rigidbody

            Vector3 direction = plane.ClosestPointOnPlane(collider.transform.position) - collider.transform.position;

            //Debug.Log(plane.ClosestPointOnPlane(collider.transform.position));

            if (direction.magnitude < MinRadius) continue;

            float distance = direction.sqrMagnitude * DistanceMultiplier + 1; // The distance formula

            // Object mass also affects the gravitational pull
            rb.AddForce(direction.normalized * (GravitationalPull / distance) * rb.mass * Time.fixedDeltaTime);

            Vector3 toTarget = (collider.transform.position - transform.position).normalized;
            float dist = Vector3.Distance(collider.transform.position, transform.position);

            if (Vector3.Dot(toTarget, transform.up) < 0 || dist > 4)
            {
                //Debug.Log("Target is in front of this game object.");
                collider.transform.position = transform.position;

            }
        }
    }
}
