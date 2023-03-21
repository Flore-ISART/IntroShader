using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{
    public uint maxHP;
    
    [SerializeField] private uint startingHP;

    public uint health { get; private set; }

    private void Start()
    {
        health = startingHP;
    }

    private void ChangeHealth(int healthPoint)
    {
        var unclampedHealth = (int)health + healthPoint;
        health = (uint)Mathf.Clamp(unclampedHealth, 0, maxHP);
        CheckDeath();
    }

    private void CheckDeath()
    {
        if (health == 0)
        {
            Destroy(GetComponent<PlayerInput>());
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent<ModifyPlayerHealth>(out var modifyComponent))
        {
            ChangeHealth(modifyComponent.modifier);
        }
    }
}