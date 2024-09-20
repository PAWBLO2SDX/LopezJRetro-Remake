using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    public Sprite[] animationSprites;

    public float animationTime;

    private SpriteRenderer _spriteRenderer;

    private int _animationFrame;


    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        

        
        {
            InvokeRepeating(nameof(AnimateSprite), this.animationTime);
        }
    }

    private void InvokeRepeating(string v, float animationTime)
    {
        throw new NotImplementedException();
    }

    private void AnimateSprite()
    {
        _animationFrame++;

        if(_animationFrame >= this.animationSprites.Length)
        {

        }
        _animationFrame = 0;
        _spriteRenderer.sprite = this.animationSprites[_animationFrame];
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
