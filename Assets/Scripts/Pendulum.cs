using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float angle = 45f;

    void Update()
    {
        float rotation = Mathf.Sin(Time.time * speed) * angle;
        transform.localRotation = Quaternion.Euler(rotation, 0, 0);
    } 
}
