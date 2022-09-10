using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollDeath : MonoBehaviour
{
    private Rigidbody[] rigidbodies;
    [SerializeField] private Collider[] colliders;
    void Start()
    {
        rigidbodies = GetComponentsInChildren<Rigidbody>();
        colliders = GetComponentsInChildren<Collider>();

        ToggleRagdoll(false);
    }

    

    public void ToggleRagdoll(bool state)
    {
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = !state;
        }

        foreach (Collider cd in colliders)
        {
            cd.enabled = state;
        }
    }
}
