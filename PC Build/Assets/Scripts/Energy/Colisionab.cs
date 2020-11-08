using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionab : MonoBehaviour
{
    public GameObject a;
    public GameObject ab;
    public GameObject b;

        void OnCollisionEnter (Collision collision)
        {
            ab.SetActive(true);

        }

}
