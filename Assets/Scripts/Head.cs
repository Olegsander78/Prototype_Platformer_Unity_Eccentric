using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Transform TransformTarget;
    void Update()
    {
        transform.position = TransformTarget.position;
    }
}
