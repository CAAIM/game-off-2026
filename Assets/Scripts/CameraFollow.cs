using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private float startingY;
    private float startingZ;

    void Start()
    {
        startingY = transform.position.y;
        startingZ = transform.position.z;
    }

    void LateUpdate()
    {
        if (player == null) return;

        transform.position = new Vector3(
            player.position.x + 3f,
            startingY,
            startingZ
        );
    }
}