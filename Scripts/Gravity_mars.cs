using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_mars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<ConstantForce>().force = new Vector3(0, -3.720f, 0);
    }
}
