using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Wave
{
    [Range(0f, 1f)]
    public float s;
    [Range(0f, 1f)]
    public float amp;
    [Range(0.0001f, 2* Mathf.PI)]
    public float lmbd;
    public float flowSpeed;
    [Range(1f, 2f)]
    public float weight;
    public float offset;
    public Vector3 direction;

    //public float GetSteepness()
    //{
    //    float k = 2 * Mathf.PI / lmbd;
    //    return amp / k;
    //}
}
