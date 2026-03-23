using UnityEngine;

public class Camera_Rotator : MonoBehaviour
{
    [SerializeField] Vector3 rotateAxis; 
    void Update()
    {
        transform.Rotate(rotateAxis * Time.deltaTime);
    }
}
