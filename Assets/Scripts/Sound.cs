using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource AudioSource;

    public void UnparentAndPlay()
    {
        transform.parent = null;
        AudioSource.Play();
    }
         
}
