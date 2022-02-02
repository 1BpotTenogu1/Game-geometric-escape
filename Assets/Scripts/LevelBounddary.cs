using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBounddary : MonoBehaviour
{
    public static float LeftSide = 7.5f;
    public static float RightSide = 12.5f;
    public float InternalLeft;
    public float InternalRight;
    void Update()
    {
        InternalLeft = LeftSide;
        InternalRight = RightSide;
    }
}
