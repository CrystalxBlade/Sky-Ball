using UnityEngine;

public class Camera_Rotator : MonoBehaviour
{
    [SerializeField] Vector3 rotateAxis;
    void Update()
    {
        transform.Translate(rotateAxis);
    }
}
