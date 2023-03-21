using UnityEngine;

public class ModifyPlayerHealth : MonoBehaviour
{
    public int modifier;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        animator.SetBool("InTrigger", true);
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        animator.SetBool("InTrigger", false);
    }
}