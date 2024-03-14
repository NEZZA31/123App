using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField] private AnimationCurve _movingcurve;
    private float currentTime;
    private float totalTime;
    void Start()
    {
        totalTime = _movingcurve.keys[_movingcurve.keys.Length - 1].time;
    }

    void FixedUpdate()
    {
        gameObject.transform.position =
            new Vector3(transform.position.x,
            _movingcurve.Evaluate(currentTime), transform.position.z);
        currentTime += Time.fixedDeltaTime;
        if (currentTime >= totalTime)
        {
            currentTime = 0;
        }
    }
}
