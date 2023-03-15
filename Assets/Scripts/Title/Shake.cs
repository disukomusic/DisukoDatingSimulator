using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Shake : MonoBehaviour
{
    public float wiggleRange;
    public float speed;
    public AnimationCurve ease;


    private float _t = 0;
    private Vector3 _originalPosition;

    void Awake()
    {
        _originalPosition = transform.position;
    }

    void FixedUpdate()
    {
        MoveTo(_originalPosition + GetRandomVector3(wiggleRange));
        _t += Time.deltaTime;
        Debug.Log(_t);
    }

    void MoveTo(Vector3 newPos)
    {
        Vector3 currentPos = transform.position;

        if (currentPos != newPos)
        {
            transform.position = Vector3.Lerp(currentPos, newPos, ease.Evaluate(_t / speed));
        }
        else
        {
            _t = 0;
        }
    }

    Vector3 GetRandomVector3(float range)
    {
        Vector3 randomVector3 = new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));
        return randomVector3;
    }
}
