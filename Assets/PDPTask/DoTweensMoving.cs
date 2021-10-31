using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class DoTweensMoving : MonoBehaviour
{

    [SerializeField]
    private Vector3 _targetPosition = Vector3.zero;

    [Range (0.1f, 100f), SerializeField]
    private float moveDuration = 1;

    [SerializeField]
    private Ease ease = Ease.Linear;

    [Range(0.1f, 10), SerializeField]
    private float loopWait;





    void Start()
    {
        
    
            if (_targetPosition == Vector3.zero)
            {
                _targetPosition = transform.position;

                
            }
        //transform.DOMove(_targetPosition, moveDuration).SetEase(ease);
        IsMoving();
        
        
        
    }

    private void IsMoving()
    {
        StartCoroutine(MovingLoop());
    }

   private IEnumerator MovingLoop()
    {
        Vector3 originalPosition = transform.position;
        transform.DOMove(_targetPosition, moveDuration).SetEase(ease);
        yield return new WaitForSeconds(loopWait);
        transform.DOMove(originalPosition, moveDuration).SetEase(ease);
    }
       

   
    
}
