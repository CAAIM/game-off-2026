using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRunner : MonoBehaviour
{
    public float runSpeed = 2f;
    public float jumpForce = 8f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        body.linearVelocity = new Vector2(
            runSpeed, body.linearVelocity.y
        );

        bool isGrounded = Physics2D.OverlapCircle(
            groundCheck.position, 0.1f, groundLayer
        ) != null;

        if (Keyboard.current != null &&
            Keyboard.current.spaceKey.wasPressedThisFrame &&
            isGrounded && body.linearVelocity.y <= 0.1f)
        {
            body.linearVelocity = new Vector2(
                runSpeed, jumpForce
            );
        }
    }
}