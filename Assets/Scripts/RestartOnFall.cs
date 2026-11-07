using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RestartOnFall : MonoBehaviour
{
    void Update()
    {
        bool restartPressed = Keyboard.current != null &&
            Keyboard.current.rKey.wasPressedThisFrame;

        if (transform.position.y < -10f || restartPressed)
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name
            );
        }
    }
}