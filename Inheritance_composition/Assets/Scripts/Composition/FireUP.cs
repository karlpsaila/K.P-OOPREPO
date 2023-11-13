using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireUP : MonoBehaviour
{

    [SerializeField] float ySpeed;

    public void Fire(Rigidbody2D rb)
    {
        Vector2 myYforce = new Vector2(0, ySpeed);
        rb.AddForce(myYforce);
    }
}
