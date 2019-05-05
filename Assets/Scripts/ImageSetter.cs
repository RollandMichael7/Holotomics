using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSetter : MonoBehaviour
{
    private Image imageComponent;

    void Start()
    {
        this.imageComponent = this.GetComponent<Image>();
    }

    public void setImage(string image)
    {
        this.imageComponent.sprite = Resources.Load<Sprite>("Holograms/" + image);
    }
}
