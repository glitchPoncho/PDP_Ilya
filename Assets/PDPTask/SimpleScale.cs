using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SimpleScale : MonoBehaviour
{

    public Transform Cylinder;
    public float duration;
    public float scaleValue;
    public Ease ease;
    void Start()
    {
        Cylinder
            .DOScale(scaleValue, duration)
            .SetEase(ease)
            .SetLoops(-1,LoopType.Yoyo);

    }

}