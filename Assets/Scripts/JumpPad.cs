using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] float jumpForce;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(transform.up * jumpForce);
        }
    }
}
