using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class RobotBuilder : MonoBehaviour
    {
        public Head robotHead;
        public Body robotBody;
        public Leg robotLeg;
        public Arm robotArm;
        public void BuildRobot()
        {
            robotHead.CreateHead();
            robotBody.CreateBody();
            robotLeg.CreateLeg();
            robotArm.CreateArm();
        }
    }
}
