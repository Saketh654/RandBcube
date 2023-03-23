using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float playerSpeed = 30f;
    public float gravity = -9.8f;
    public CharacterController controller;
    public float jumpHeight = 10f;
    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundMask;
    public int speedMultiplier = 5;

    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.5f, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * x + transform.forward * z);

        controller.Move(move * playerSpeed * Time.deltaTime);

        if(!isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }

        if(isGrounded && velocity.y<0)
        {
            velocity.y = 0;
        }

        controller.Move(velocity * Time.deltaTime);

        if(Input.GetButton("Jump")&&isGrounded)
        {
            Debug.Log("Space Bar Pressed");
            velocity.y = Mathf.Sqrt(-2f * gravity * jumpHeight);
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed *= speedMultiplier;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed /= speedMultiplier;
        }
    }
}
