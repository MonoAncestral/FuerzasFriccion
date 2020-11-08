using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_soga : MonoBehaviour
{
    public Vector3 fuerzap;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.GetChild(transform.childCount - 1).GetComponent<Rigidbody>().AddForce(fuerzap, ForceMode.Impulse);
    }
}
