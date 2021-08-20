using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSliders : MonoBehaviour
{

    public MeshRenderer mrCapsule;
    public Slider sRed;
    public Slider sGreen;
    public Slider sBlue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Called only when the slider value is changed
    public void OnEdit()
    {
        Color color = mrCapsule.material.color;
        color.r = sRed.value;
        color.g = sGreen.value;
        color.b = sBlue.value;
        mrCapsule.material.color = color;
    }
}
