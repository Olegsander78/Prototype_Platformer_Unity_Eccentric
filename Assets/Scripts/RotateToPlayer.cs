using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Vector3 LeftEuler;
    public Vector3 RigthEuler;
    private Transform _playerTransform;
    private Vector3 _targetEuler;
    public float SpeedRotation = 5f;
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < _playerTransform.position.x)
        {
            _targetEuler = RigthEuler;
        }
        else
        {
            _targetEuler = LeftEuler;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_targetEuler), Time.deltaTime * SpeedRotation);
    }
}
