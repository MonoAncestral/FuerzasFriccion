using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class Seleccion : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI textMP;

     void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        textMP.text= player.tag;

    }


}
