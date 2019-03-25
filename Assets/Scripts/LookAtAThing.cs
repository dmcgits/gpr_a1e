using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LookAtAThing : MonoBehaviour {

    [SerializeField]
    protected Transform targetTransform;

    protected Transform myTransform;

    void Start()
    {
        myTransform = gameObject.transform;
    }

    // Update is called once per frame
    void Update () {
        Handies.PointObjectAtAnother(myTransform, targetTransform);     
	}
}
