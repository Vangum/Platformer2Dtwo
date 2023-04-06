using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FallingTrap : MonoBehaviour
{
    public PlayerLife playerLife;
    Rigidbody2D rb;
    [SerializeField] private AudioSource deathSoundEffect;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerLife = GetComponent<PlayerLife>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            rb.isKinematic = false;
        }
    }

}
