using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionSoga : MonoBehaviour
{
private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "cuerda")
            Destroy(other.gameObject);
    }
}
