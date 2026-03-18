using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float xInput, zInput;
    Rigidbody rb; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        rb.AddForce(new Vector3(xInput, 0, zInput) * moveSpeed);
    }

}
