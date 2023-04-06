using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Invoke("FallPlatform", 0.7f);
            Destroy(gameObject, 1.1f);
        }
    }

    private void FallPlatform()
    {
        rb.isKinematic = false;
    }
}
