using System;
using UnityEngine;

public class PlayerShader : MonoBehaviour
{
    [Serializable]
    public struct ToChangeOnHit
    {
        public Material material;
        public Sprite sprite;

        public ToChangeOnHit(Material material, Sprite sprite)
        {
            this.material = material;
            this.sprite = sprite;
        }
    }

    public ToChangeOnHit[] toChangeOnHits;
    public SpriteRenderer robotBodyRenderer;

    private uint currentHealth;
    private PlayerHealth healthComponent;

    private void Awake()
    {
        healthComponent = GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        if (currentHealth == healthComponent.health) return;
        currentHealth = healthComponent.health;
        robotBodyRenderer.material = toChangeOnHits[currentHealth].material;
        robotBodyRenderer.sprite = toChangeOnHits[currentHealth].sprite;
    }
}