using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public Renderer[] Renderers;
    public AnimationCurve AnimationCurve;

    public void StartBlink()
    {
        StartCoroutine(BlinkEffect());
    }

    public IEnumerator BlinkEffect()
    {
        for (float t = 0; t < 1; t+=Time.deltaTime)
        {
            float red = Mathf.Sin(t * 30) * 0.5f + 0.5f;
            //Debug.Log(red);

            Keyframe key = new Keyframe(Time.time, red, 0, 0, 0, 0);
            AnimationCurve.AddKey(key);

            for (int i = 0; i < Renderers.Length; i++)
            {
                for (int m = 0; m < Renderers[i].materials.Length ; m++)
                {
                    Renderers[i].materials[m].SetColor("_EmissionColor", new Color(red, 0, 0, 0));
                }
            }
            yield return null;
        }
        for (int i = 0; i < Renderers.Length; i++)
        {
            for (int m = 0; m < Renderers[i].materials.Length; m++)
            {
                Renderers[i].materials[m].SetColor("_EmissionColor", new Color(0, 0, 0, 0));
            }
        }
    }
}
