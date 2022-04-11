using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for mouse utility.
/// </summary>
public class Utility
{
    /// <summary>
    /// Returns the angle of where the mouse is. Used for when you want
    /// an object to point at the mouse.
    /// </summary>
    /// <param name="pos">a Vector3</param>
    /// <returns>a float</returns>
    public static float AngleTowardsMouse(Vector3 pos)
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(pos);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        return angle;
    }
}
