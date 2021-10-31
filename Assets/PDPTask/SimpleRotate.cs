using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SimpleRotate : MonoBehaviour
{
    public Transform Cube2;
    public float duration;
    public Vector3 rotationAxis;
    public Ease ease;
    void Start()
    {
        Cube2
            .DORotate(rotationAxis, duration)
            .SetEase(ease)
            .SetLoops(-1, LoopType.Yoyo);
    }

    
}
