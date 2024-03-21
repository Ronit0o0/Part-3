using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDemo : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpolation;
    public void SliderValueHasChanged(Single value)
    {
        interpolation = value;
    }

    private void Update()
    {
        sr.color = Color.Lerp(start, end, interpolation/60);
    }
}
