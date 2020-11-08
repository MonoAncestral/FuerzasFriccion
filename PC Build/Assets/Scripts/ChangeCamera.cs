﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

    private GameObject Camera;
    private Vector3 InitVec;
    private Quaternion InitRot;
    private Quaternion Rot;
    private bool OnKeyPressed = false;
    private bool OnWRotate = false; private bool OnWPosition = false;
    private bool OnSRotate = false; private bool OnSPosition = false;
    private bool OnARotate = false; private bool OnAPosition = false;
    private bool OnDRotate = false; private bool OnDPosition = false;

    private void Start()
    {
        Camera = this.gameObject;
        InitVec = Camera.transform.position;
        InitRot = Camera.transform.rotation;
        Rot = InitRot;
    }

    void Update () {
        if(ResultTable.TableOpen == false)
        {
            if ((Camera.transform.position == InitVec && OnSRotate == false && OnWRotate == false && OnARotate == false && OnDRotate == false) || OnKeyPressed == true)
            {
                if (Camera.transform.rotation == InitRot || OnKeyPressed == true)
                {
                    if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
                    {
                        OnKeyPressed = true;
                        OnWRotate = true;
                        OnWPosition = true;
                        if ((int)Camera.transform.rotation.eulerAngles.x < 90)
                        {
                            Rot.eulerAngles += new Vector3(1, 0, 0);
                            Camera.transform.rotation = Rot;
                        }
                        if (Camera.transform.position.z < 20.5)
                        {
                            Camera.transform.position += new Vector3(0, 0, 0.05f);
                        }
                        if (Camera.transform.position.y < 8)
                        {
                            Camera.transform.position += new Vector3(0, 0.05f, 0);
                        }
                    }
                    else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
                    {
                        OnKeyPressed = true;
                        OnSRotate = true;
                        OnSPosition = true;
                        if ((int)Camera.transform.rotation.eulerAngles.x > 352 || (int)Camera.transform.rotation.eulerAngles.x == 0)
                        {
                            Rot.eulerAngles -= new Vector3(1, 0, 0);
                            Camera.transform.rotation = Rot;
                        }
                        if (Camera.transform.position.z < 18)
                        {
                            Camera.transform.position += new Vector3(0, 0, 0.05f);
                        }
                        if (Camera.transform.position.y > 2.4)
                        {
                            Camera.transform.position -= new Vector3(0, 0.05f, 0);
                        }
                    }
                    else if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
                    {
                        OnKeyPressed = true;
                        OnARotate = true;
                        OnAPosition = true;
                        if ((int)Camera.transform.rotation.eulerAngles.y < 90)
                        {
                            Rot.eulerAngles += new Vector3(0, 0.7f, 0);
                            Camera.transform.rotation = Rot;
                        }
                        if (Camera.transform.position.x > 34)
                        {
                            Camera.transform.position -= new Vector3(0.05f, 0, 0);
                        }
                        if (Camera.transform.position.z < 21)
                        {
                            Camera.transform.position += new Vector3(0, 0, 0.04f);
                        }
                    }
                    else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
                    {
                        OnKeyPressed = true;
                        OnDRotate = true;
                        OnDPosition = true;
                        if ((int)Camera.transform.rotation.eulerAngles.y > 270 || (int)Camera.transform.rotation.eulerAngles.y == 0)
                        {
                            Rot.eulerAngles -= new Vector3(0, 0.7f, 0);
                            Camera.transform.rotation = Rot;
                        }
                        if (Camera.transform.position.x < 47)
                        {
                            Camera.transform.position += new Vector3(0.05f, 0, 0);
                        }
                        if (Camera.transform.position.z < 21)
                        {
                            Camera.transform.position += new Vector3(0, 0, 0.04f);
                        }
                    }
                    else
                    {
                        OnKeyPressed = false;
                    }
                }
            }
            else
            {
                if (Camera.transform.rotation != InitRot)
                {
                    //KeyCode.W
                    if ((int)Camera.transform.rotation.eulerAngles.x - 1 > 0 && OnWRotate)
                    {
                        Rot.eulerAngles -= new Vector3(1, 0, 0);
                        Camera.transform.rotation = Rot;
                    }
                    else if (OnWRotate)
                    {
                        OnWRotate = false;
                        Rot = InitRot;
                        Camera.transform.rotation = Rot;
                    }
                    //KeyCode.S
                    if (((int)Camera.transform.rotation.eulerAngles.x + 1 < 360 && (int)Camera.transform.rotation.eulerAngles.x != 0) && OnSRotate)
                    {
                        Rot.eulerAngles += new Vector3(1, 0, 0);
                        Camera.transform.rotation = Rot;
                    }
                    else if (OnSRotate)
                    {
                        OnSRotate = false;
                        Rot = InitRot;
                        Camera.transform.rotation = Rot;
                    }
                    //KeyCode.A
                    if ((int)Camera.transform.rotation.eulerAngles.y - 0.7 > 0 && OnARotate)
                    {
                        Rot.eulerAngles -= new Vector3(0, 0.7f, 0);
                        Camera.transform.rotation = Rot;
                    }
                    else if (OnARotate)
                    {
                        OnARotate = false;
                        Rot = InitRot;
                        Camera.transform.rotation = Rot;
                    }
                    //KeyCode.D
                    if (((int)Camera.transform.rotation.eulerAngles.y + 0.7 < 360 && (int)Camera.transform.rotation.eulerAngles.y != 0) && OnDRotate)
                    {
                        Rot.eulerAngles += new Vector3(0, 0.7f, 0);
                        Camera.transform.rotation = Rot;
                    }
                    else if (OnDRotate)
                    {
                        OnDRotate = false;
                        Rot = InitRot;
                        Camera.transform.rotation = Rot;
                    }
                }
                if (Camera.transform.position != InitVec)
                {
                    //KeyCode.W
                    if (Camera.transform.position.z - 0.05 > 16 && OnWPosition)
                    {
                        Camera.transform.position -= new Vector3(0, 0, 0.05f);
                    }
                    else if (OnWPosition)
                    {
                        OnWPosition = false;
                        Camera.transform.position = InitVec;
                    }
                    if (Camera.transform.position.y - 0.05 > 4 && OnWPosition)
                    {
                        Camera.transform.position -= new Vector3(0, 0.05f, 0);
                    }
                    else if (OnWPosition)
                    {
                        OnWPosition = false;
                        Camera.transform.position = InitVec;
                    }
                    //KeyCode.S
                    if (Camera.transform.position.z - 0.05 > 16 && OnSPosition)
                    {
                        Camera.transform.position -= new Vector3(0, 0, 0.05f);
                    }
                    else if (OnSPosition)
                    {
                        OnSPosition = false;
                        Camera.transform.position = InitVec;
                    }
                    if (Camera.transform.position.y + 0.05 < 4 && OnSPosition)
                    {
                        Camera.transform.position += new Vector3(0, 0.05f, 0);
                    }
                    else if (OnSPosition)
                    {
                        OnSPosition = false;
                        Camera.transform.position = InitVec;
                    }
                    //KeyCode.A
                    if (Camera.transform.position.x + 0.05 < 40.75 && OnAPosition)
                    {
                        Camera.transform.position += new Vector3(0.05f, 0, 0);
                    }
                    else if (OnAPosition)
                    {
                        OnAPosition = false;
                        Camera.transform.position = InitVec;
                    }
                    if (Camera.transform.position.z - 0.04 > 16 && OnAPosition)
                    {
                        Camera.transform.position -= new Vector3(0, 0, 0.04f);
                    }
                    else if (OnAPosition)
                    {
                        OnAPosition = false;
                        Camera.transform.position = InitVec;
                    }
                    //KeyCode.D
                    if (Camera.transform.position.x - 0.05 > 40.75 && OnDPosition)
                    {
                        Camera.transform.position -= new Vector3(0.05f, 0, 0);
                    }
                    else if (OnDPosition)
                    {
                        OnDPosition = false;
                        Camera.transform.position = InitVec;
                    }
                    if (Camera.transform.position.z - 0.04 > 16 && OnDPosition)
                    {
                        Camera.transform.position -= new Vector3(0, 0, 0.04f);
                    }
                    else if (OnDPosition)
                    {
                        OnDPosition = false;
                        Camera.transform.position = InitVec;
                    }
                }
            }
        }
    }
}
