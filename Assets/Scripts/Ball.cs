using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Transform cam;
    Rigidbody rb;
    float xInput, zInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        Vector3 forward = cam.forward;
        Vector3 right = cam.right;

        forward.y = 0;
        right.y = 0;

        Vector3 moveDirection = (forward * zInput + right * xInput).normalized;

        rb.AddForce(moveDirection * moveSpeed);
    }
}