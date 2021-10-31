using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SimpleMove : MonoBehaviour
{
    public Transform cube;
    public float duration;
    public Vector3 moveValue;

    public Ease ease;

   

    void Start()
    {
        cube
            .DOMove(moveValue, duration)
            .SetEase(ease)
            .SetLoops(-1,LoopType.Yoyo);
    }

    
}
