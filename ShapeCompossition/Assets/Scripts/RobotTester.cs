using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static RobotBody;

public class RobotTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    public RobotBuilder robotBuilder;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            robotBuilder.BuildRobot();
        }
    }

}
