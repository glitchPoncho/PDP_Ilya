using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SimplePath : MonoBehaviour
{
    public Transform Ball;
    public float duration;

    public Vector3[] path;
    public PathType pathType;
    public PathMode pathMode;

    void Start()
    {
        Ball
            .DOPath(path, duration, pathType, pathMode, 10)
            .SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
