using UnityEngine;
using UnityEngine.InputSystem;

public class WorldSwap : MonoBehaviour
{
    public GameObject redPlatforms;
    public GameObject bluePlatforms;

    private bool isRed = true;
    private SpriteRenderer playerSprite;

    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        ApplyWorld();
    }

    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.leftShiftKey.wasPressedThisFrame ||
            Keyboard.current.rightShiftKey.wasPressedThisFrame)
        {
            isRed = !isRed;
            ApplyWorld();
        }
    }

    void ApplyWorld()
    {
        playerSprite.color = isRed ? Color.red : Color.blue;
        redPlatforms.SetActive(isRed);
        bluePlatforms.SetActive(!isRed);
    }
}