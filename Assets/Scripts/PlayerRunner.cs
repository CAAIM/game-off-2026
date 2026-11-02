using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRunner : MonoBehaviour
{
    public float runSpeed = 5f;    // how fast you move right
    public float jumpForce = 8f;   // how high you jump

    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();   // grab the physics part
    }

    void Update()
    {
        // keep moving right, keep current up/down speed
        body.linearVelocity = new Vector2(runSpeed, body.linearVelocity.y);

        // press Space to jump
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, jumpForce);
        }
    }
}