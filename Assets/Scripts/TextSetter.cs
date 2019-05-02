using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSetter : MonoBehaviour
{
    private Text textComponent;
    
    void Start()
    {
        this.textComponent = this.GetComponent<Text>();
    }

    public void getElementInfo(string element)
    {
        ElementInfo elements = ElementInfo.CreateFromJSON("Text/element_info");
        this.textComponent.text = elements.getElementInfo(element);
    }

    public void setText(string text)
    {
        this.textComponent.text = text;
    }
}
