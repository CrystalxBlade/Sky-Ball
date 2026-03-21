using System.Collections.Generic;
using UnityEngine;

public class Platform_Attach : MonoBehaviour
{
    List<Rigidbody> rigidbodies = new List<Rigidbody>();
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision c)
    {
        Rigidbody rb = c.collider.GetComponent<Rigidbody>();
        if(rb != null)
        {
            Add(rb);
        }
    }
    void OnCollisionExit(Collision c)
    {
        Rigidbody rb = c.collider.GetComponent<Rigidbody>();
        if(rb != null)
        {
            Remove(rb);
        }
    }
    void Add(Rigidbody rb)
    {
        if(rb == null)
        rigidbodies.Add(rb);
    }
    void Remove(Rigidbody rb)
    {
        if(rb != null)
        rigidbodies.Remove(rb);
    }
}