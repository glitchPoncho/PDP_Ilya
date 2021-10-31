using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SimplePuch : MonoBehaviour
{
    public Transform meshHere;
    public float duration;
    public Ease ease;
    public Vector3 AxisPunch = new Vector3(1, 1, 1);

    void Start()
    {
        meshHere
            .DOPunchScale(AxisPunch, duration, 10, 1)
            //.SetEase(ease);
            .SetLoops(-1, LoopType.Yoyo);
    }

   
}
