using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject ArmShape;
    public void CreateArm()
    {
        Instantiate(ArmShape, transform.position,
       Quaternion.identity, transform);
    }
}
