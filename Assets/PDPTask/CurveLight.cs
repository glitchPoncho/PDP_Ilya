using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class CurveLight : MonoBehaviour
    {
        [SerializeField] AnimationCurve lightIntensity;

        float currentTime, totalTime;
        [SerializeField]
        new Light light;
        // Start is called before the first frame update
        void Start()
        {
            totalTime = lightIntensity.keys[lightIntensity.keys.Length - 1].time;
        }

        // Update is called once per frame
        void Update()
        {
            light.intensity = lightIntensity.Evaluate(currentTime);
            currentTime += Time.deltaTime;

            if (currentTime >= totalTime)
                currentTime = 0;
        }
    }

