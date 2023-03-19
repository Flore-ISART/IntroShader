using UnityEngine;

public class DissolveCircle : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private float scrollSpeed;

    // Start is called before the first frame update
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        // Le nom des variables à modifier dans les matériaux sont toujours les "références" du shadergraph
        // Ce n’est JAMAIS le nom dans l’inspector
        scrollSpeed = spriteRenderer.material.GetFloat("_Vertical_Scrolling");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            animator.SetTrigger("ChangeState");
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            scrollSpeed *= 2;
            // Le nom des variables à modifier dans les matériaux sont toujours les "références" du shadergraph
            // Ce n’est JAMAIS le nom dans l’inspector
            spriteRenderer.material.SetFloat("_Vertical_Scrolling", scrollSpeed);
        }
    }
}