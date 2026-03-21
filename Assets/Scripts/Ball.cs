using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float moveSpeed, jumpForce;
    [SerializeField] Transform cam;
    Rigidbody rb;
    bool isGrounded;
    bool jumpRequest;
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

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if(Input.GetButtonDown("Jump"))
        {
            isGrounded = true;
        }
    }
    void FixedUpdate()
    {
        Move();

        if(isGrounded)
        {
            Jump();
        }
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
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}