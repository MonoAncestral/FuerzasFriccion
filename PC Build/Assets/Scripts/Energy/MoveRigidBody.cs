using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidBody : MonoBehaviour
{
    public float speed = 10f;
    void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.forward * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.back * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.left * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.right * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log("jueputa");
    }
}
