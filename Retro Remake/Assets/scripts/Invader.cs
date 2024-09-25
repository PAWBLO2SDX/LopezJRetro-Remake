using UnityEngine;

public class Invader : MonoBehaviour
{
    public Sprite[] animationSprites;
  
    public float animaionTime = 1.0f;

    private float animationTime;

    private SpriteRenderer _spriteRenderer;

    private int _animationFrame;


    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), this.animationTime, this.animationTime);
    }

    private void AnimateSprite()
    {
        _animationFrame++;

        if (_animationFrame >= animationSprites.Length) {
            _animationFrame = 0;
        }

            _spriteRenderer.sprite = animationSprites[_animationFrame];
    }
}
