using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handies {

    public static void PointObjectAtAnother(Transform o1, Transform o2)
    {
        //o1.LookAt(o2);
        float angleRad = Mathf.Atan2(o2.position.y - o1.position.y, o2.position.x - o1.position.x);
        float angleDeg = Mathf.Rad2Deg * angleRad;

        o1.rotation = Quaternion.Euler(0, 0, angleDeg-90);
        //Debug.Log(angleDeg);
    }

    public static Vector3 MousePosToWorldVec()
    {
        Camera cam = Camera.main;
        Vector3 mousePoint = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        mousePoint.z = 0; // ScreenToWorld sets z to -10, which is makes the sprite invisible
        return (mousePoint);
    }
}
