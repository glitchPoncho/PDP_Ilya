using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SimpleFade : MonoBehaviour
{
    public MeshRenderer mesh;
    public float duration;
    public Ease ease;

    void Start()
    {

        mesh.material.DOFade(0, duration)
            .SetEase(ease)
            .SetLoops(-1, LoopType.Yoyo);

    }

    
   
}
