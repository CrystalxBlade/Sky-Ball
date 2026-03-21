using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    [SerializeField] Transform pointA, pointB;
    [SerializeField] float _moveSpeed;
    Transform target;
    void Start()
    {
        target = pointB;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, _moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, target.position) < 0.01f)
        {
            if(target == pointA)
                target = pointB;
            else
                target = pointA;
        }  
    }
}
