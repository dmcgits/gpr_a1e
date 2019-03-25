using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheMouse : MonoBehaviour {

    protected Transform myTrans;
    protected Camera cam;
    protected Vector3 mousePoint;
	// Use this for initialization
	void Start () {
        myTrans = gameObject.transform;
        cam = Camera.main;    
	}
	
	// Update is called once per frame
	void Update () {
        mousePoint = Handies.MousePosToWorldVec();
        myTrans.position = mousePoint; 
	}
}
