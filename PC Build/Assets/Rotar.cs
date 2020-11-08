using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class Rotar: MonoBehaviour
{
    public TMP_InputField tmpInputField;
    public GameObject player;
    public float rotateSpeed;
    private string direccion = "forward";
    bool rotatestatus = false;
    private int i = 0;
    float angulo = 0;
    // Start is called before the first frame update
  public void rotando() {
      if(!rotatestatus){
        if(tmpInputField.text!="")
        { 
            angulo = float.Parse(tmpInputField.text);
            rotatestatus = true;
            if(player.transform.eulerAngles.z > float.Parse(tmpInputField.text))
            {
                direccion="back";
            }
            else
            {
                direccion="forward";
            }
        }
        
          
      }
  }

    // Update is called once per frame
     void Update()
    {
        if(rotatestatus == true){
            if(int.TryParse(tmpInputField.text, out i))
            {
                if(direccion=="forward")
                {
                    player.transform.Rotate(Vector3.forward, rotateSpeed*Time.deltaTime);
                    if(player.transform.eulerAngles.z > angulo)
                    {
                        player.transform.Rotate(Vector3.forward, 0*Time.deltaTime);
                        rotatestatus=false;
                    }
                }
                else
                {
                    player.transform.Rotate(Vector3.back, rotateSpeed*Time.deltaTime);
                    if(player.transform.eulerAngles.z < angulo)
                    {
                        player.transform.Rotate(Vector3.forward, 0*Time.deltaTime);
                        rotatestatus=false;
                    }
                }
            }
            else
            {
                tmpInputField.text="";
                MessageConsole.Message = "Valor inválido";
            } 
        }

    }
}