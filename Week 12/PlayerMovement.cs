using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;

    public Sprite soytop;
    public Sprite soydown;
    public Sprite soyleft;
    public Sprite soyright;

    // TASK 1: the Weapon object (FirePoint is its child, so it turns with it)
    public Transform weapon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = soyleft;
            FaceWeapon(180f);   // point left
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = soyright;
            FaceWeapon(0f);     // point right
        }
        else
        {
            speedX = 0;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = soytop;
            FaceWeapon(90f);    // point up
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = soydown;
            FaceWeapon(-90f);   // point down
        }
        else
        {
            speedY = 0;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }

    // TASK 1: spin the Weapon (and the FirePoint inside it) to face the way the player is moving
    void FaceWeapon(float angle)
    {
        weapon.localRotation = Quaternion.Euler(0f, 0f, angle);
    }
}
