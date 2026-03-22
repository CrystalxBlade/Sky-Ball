using NUnit.Framework;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    [SerializeField] Transform pointA, pointB;
    [SerializeField] float _moveSpeed;
    Transform target;
    [SerializeField] float waitTime;
    float waitTimer;
    bool isWaiting;
    void Start()
    {
        target = pointB;
    }
    void Update()
    {
        if(isWaiting)
        {
            waitTimer += Time.deltaTime;

            if(waitTimer >= waitTime)
            {
                isWaiting = false;
                waitTimer = 0;

                target =  target ==  pointA ? pointB : pointA;
            }
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, _moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, target.position) < 0.01f)
        {
            isWaiting = true;
        }  
    }
}
