using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EvetsArray : MonoBehaviour
{
    public UnityEvent[] Events;

    public void StartEvent(int eventIndex)
    {
        Events[eventIndex].Invoke();
    }
}
