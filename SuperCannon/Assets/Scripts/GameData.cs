using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    private static Vector3 _mousePos, _Xmin, _Xmax, _Ymin, _Ymax;

    private static Vector3 mousePos;
    private static float _padding = 0;

    public static Vector3 MousePos
    {
        get { return GetMousePos(); }
    }

    private static Vector3 GetMousePos()
    {

        Camera myCamera = Camera.main;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 10f);
        return mousePos;
    }

    public static float Xmin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + _padding; }
    }

    public static float Xmax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - _padding; }
    }

    public static float Ymin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + _padding; }
    }

    public static float Ymax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - _padding; }
    }
}

