using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class ActiveByDistance : MonoBehaviour
{
    public float DistanceToActivate = 20f;
    private bool _isActive = true;
    private Activator _activator;

    private void Start()
    {
        _activator = FindObjectOfType<Activator>();
        _activator.ObjectsToActivate.Add(this);
    }

    public void CheckDistance(Vector3 PlayerPosition)
    {
        float distance = Vector3.Distance(transform.position, PlayerPosition);
        if (_isActive)
        {
            if (distance > DistanceToActivate + 2f)
            {
                Deactivate();
            }
        }
        else
        {
            if (distance <= DistanceToActivate)
            {
                Activate();
            }
        }
    }
    
    public void Activate()
    {
        _isActive = true;
        gameObject.SetActive(true);
    }
    public void Deactivate()
    {
        _isActive = false;
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        _activator.ObjectsToActivate.Remove(this);
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Handles.color = Color.gray;
        Handles.DrawWireDisc(transform.position, Vector3.forward, DistanceToActivate);
    }
#endif
}
