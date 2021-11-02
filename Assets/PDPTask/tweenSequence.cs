using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class tweenSequence : MonoBehaviour
{
    Sequence seq = DOTween.Sequence();
    public Vector3 movement;
    public Vector3 rotation;
    public Vector3 scale;

    public float duration;
    // Start is called before the first frame update
    void Start()
    {
        seq.Append(transform.DOMove(movement, duration));
        seq.Join(transform.DORotate(rotation, duration));
        seq.Join(transform.DOScale(scale, duration));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
