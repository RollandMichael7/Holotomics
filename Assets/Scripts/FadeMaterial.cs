using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeMaterial : MonoBehaviour
{
    public float FadeRate=5;
    private Material mat;
    private float targetAlpha;
    // Use this for initialization
    void Start()
    {
        this.mat = this.GetComponent<MeshRenderer>().material;
        if (this.mat == null)
        {
            Debug.LogError("Error: No material on " + this.name);
        }
        this.targetAlpha = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //print("target: " + this.targetAlpha);
        Color curColor = this.mat.color;
        float alphaDiff = Mathf.Abs(curColor.a - this.targetAlpha);
        if (alphaDiff > 0.0001f)
        {
            curColor.a = Mathf.Lerp(curColor.a, targetAlpha, this.FadeRate * Time.deltaTime);
            this.mat.color = curColor;
        }

    }
    public void FadeOut()
    {
        this.targetAlpha = 0.0f;
    }

    public void FadeIn()
    {
        this.targetAlpha = 1.0f;
    }
}
