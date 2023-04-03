using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    private Animator animator;
    private PlayerHealth health;
    private static readonly int AnimatorSpeed = Animator.StringToHash("CurrentSpeed");
    private static readonly int AnimatorDeath = Animator.StringToHash("Death");

    private void Awake()
    {
        health = GetComponent<PlayerHealth>();
        animator = GetComponent<Animator>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var velocityX = myRigidbody2D.velocity.x;
        animator.SetFloat(AnimatorSpeed, Mathf.Abs(velocityX));
        if (velocityX != 0)
            transform.localScale = new Vector3(Mathf.Sign(velocityX), 1, 1);
        if(health.health == 0)
            animator.SetTrigger(AnimatorDeath);
    }
}