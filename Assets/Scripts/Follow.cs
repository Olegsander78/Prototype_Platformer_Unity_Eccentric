using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Target;
    public float LerpRate;
    void LateUpdate()
    {
       transform.position = Vector3.Lerp(transform.position, Target.position, Time.deltaTime * LerpRate);
    }
}
