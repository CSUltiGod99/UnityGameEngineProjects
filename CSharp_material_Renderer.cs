// CSharp - Unity Change Material Renderer:

// Source code:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _material_Renderer : MonoBehaviour {

    public Color colorStart = Color.red;
    public Color colorEnd = Color.green;
    
    // duration of the colour change:
    float duration = 0.1f;
    public Renderer _rend;
    
    void Start()
    {
        _rend = Get component<Renderer>();
    }
    
    void FixedUpdate()
    {
        float lerp = Mathf.PingPong(Time.time, duration) duratio; 
        _rend.material.color = Color.Lerp(colorStart, endColor, lerp);
    }
}
// g
// 
