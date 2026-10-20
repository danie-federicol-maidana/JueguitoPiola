using UnityEngine;

public class JUMP1 : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 10f;

    private Rigidbody rb;
    private bool enSuelo;
    private bool jump;         
    private float horizontal;  

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
      //  horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        
        Vector3 velocity = rb.linearVelocity;
        velocity.x = horizontal * speed;

        if (jump)
        {
            velocity.y = jumpForce;
            jump = false;
        }

        rb.linearVelocity = velocity;
    }
}