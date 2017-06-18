using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManagerScript
{

    public static float MainHorizontal()
    {
        float r = 0.0f;
        r += Input.GetAxis("J_MainHorizontal");
        return r;
    }

    public static float MainVertical()
    {
        float r = 0.0f;
        r += Input.GetAxis("J_MainVertical");
        return r;
    }

    public static Vector3 MainJoystick()
    {
        return new Vector3 ( MainHorizontal(), 0, MainVertical());
    }

}
