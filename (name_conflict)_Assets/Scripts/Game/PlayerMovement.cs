using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D myRigidbody2D;
    private float direction;

    public void OnMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<float>();
    }
    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        myRigidbody2D.velocity = new Vector2(direction * speed,0);
    }
}
