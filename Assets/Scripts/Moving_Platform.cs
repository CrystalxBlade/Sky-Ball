using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    [SerializeField] Transform pointA, pointB;
    [SerializeField] float _moveSpeed;
    Transform _transform;
    void Start()
    {
        _transform = pointB;
    }
    void Update()
    {
        
    }
}
