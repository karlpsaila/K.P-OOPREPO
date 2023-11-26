using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject LegShape;
    public void CreateLeg()
    {
        Instantiate(LegShape, transform.position,
       Quaternion.identity, transform);
    }
}
