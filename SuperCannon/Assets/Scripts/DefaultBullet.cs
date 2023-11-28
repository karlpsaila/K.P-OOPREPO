using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class DefaultBullet : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Rigidbody2D rb;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;

    }
    protected virtual void OnEnable()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    private void OnBecameInvisible()
    {
        //Destroy(this.gameObject); insted of destoy we set the bullet to inactive (goes back to the pool)
        this.gameObject.SetActive(false);
    }


}
