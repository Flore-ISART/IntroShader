using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    private Animator animator;
    private static readonly int AnimatorSpeed = Animator.StringToHash("CurrentSpeed");

    private void Awake()
    {
        animator = GetComponent<Animator>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var velocityX = myRigidbody2D.velocity.x;
        animator.SetFloat(AnimatorSpeed, Mathf.Abs(velocityX));
        if (velocityX != 0)
            transform.localScale = new Vector3(Mathf.Sign(velocityX), 1, 1);
    }
}