using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject BodyShape;
    public void CreateBody()
    {
        Instantiate(BodyShape, transform.position,
       Quaternion.identity, transform);
    }
}