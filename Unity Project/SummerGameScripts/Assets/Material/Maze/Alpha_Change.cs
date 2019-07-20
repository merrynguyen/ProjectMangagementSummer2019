using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha_Change : MonoBehaviour
{
    public Material Mat;
    private Color color;

    private void Start()
    {
        color = Mat.color;
        color.a = 1;
        Mat.color = color;
    }

    public void SetAlpha(float val)
    {
        color.a = val;
        Mat.color = color;
    }
}
