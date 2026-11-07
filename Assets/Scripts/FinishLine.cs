using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerRunner runner =
            collision.gameObject.GetComponent<PlayerRunner>();

        if (runner == null) return;

        runner.enabled = false;

        Rigidbody2D body =
            collision.gameObject.GetComponent<Rigidbody2D>();
        body.linearVelocity = Vector2.zero;

        Debug.Log("Level complete!");
    }
}