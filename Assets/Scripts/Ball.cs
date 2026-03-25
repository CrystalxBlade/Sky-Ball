using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float moveSpeed, jumpForce;
    [SerializeField] Transform cam;
    Rigidbody rb;
    float xInput, zInput;
    int groundContacts = 0;
    bool jumpRequest = false;
    bool cursorRequest;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        cursorRequest = false;
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && groundContacts > 0)
        {
            jumpRequest = true;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            cursorRequest = !cursorRequest;
            
            if(cursorRequest)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    void FixedUpdate()
    {
        Move();

        if (jumpRequest)
        {
            Jump();
            jumpRequest = false;
        }
    }

    void Move()
    {
        Vector3 forward = cam.forward;
        Vector3 right = cam.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = (forward * zInput + right * xInput).normalized;
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            groundContacts++;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            groundContacts--;
            if (groundContacts < 0)
                groundContacts = 0;
        }
    }
}