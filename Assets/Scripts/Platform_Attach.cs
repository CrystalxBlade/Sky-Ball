using System.Collections.Generic;
using UnityEngine;

public class Platform_Attach : MonoBehaviour
{
    public List<Rigidbody> rigidbodies = new List<Rigidbody>();
    public Vector3 lastPos;
    Transform _transform;
    void Start()
    {
        _transform = transform;
        lastPos = _transform.position;
    }
    void Update()
    {
        for(int i = 1; i < rigidbodies.Count; i++)
        {
            Rigidbody rb =  rigidbodies[i];
            Vector3 velocity = transform.position - lastPos;
            rb.transform.Translate(velocity, _transform);
        }
        lastPos = transform.position;
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
        if(!rigidbodies.Contains(rb))
        rigidbodies.Add(rb);
    }
    void Remove(Rigidbody rb)
    {
        if(rigidbodies.Contains(rb))
        rigidbodies.Remove(rb);
    }
}