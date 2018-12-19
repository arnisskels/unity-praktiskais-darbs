using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingsignal : MonoBehaviour {

    public Color firstColor;
    public Color secondColor;
    public float fadeInTime = 5.0F;
    public float fadeOutTime = 5.0F;
    public float fadeDelay = 10.0F;
    public MeshRenderer _meshRender;


    void Awake()
    {
        _meshRender = GetComponent<MeshRenderer> ();
    }

    private void Start()
    {
        StartCoroutine (colorLerpIn());
    }

    IEnumerator colorLerpIn()
    {
        for(float t=0.01F; t<fadeInTime; t += 0.1F)
        {
            _meshRender.material.color = Color.Lerp(firstColor, secondColor, t/fadeInTime);
            yield return null;
        }
        StartCoroutine(colorLerpOut());
    }

    IEnumerator colorLerpOut()
    {
        for (float t = 0.01F; t < fadeOutTime; t += 0.1F)
        {
            _meshRender.material.color = Color.Lerp(secondColor, firstColor, t/fadeOutTime);
            yield return null;
        }
        StartCoroutine(colorLerpIn());
    }

}
