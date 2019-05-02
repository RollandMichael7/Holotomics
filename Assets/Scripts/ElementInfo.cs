using UnityEngine;

[System.Serializable]
public class ElementInfo
{
    public string hydrogen;

    public static ElementInfo CreateFromJSON(string path)
    {
        TextAsset text = Resources.Load<TextAsset>(path);
        ElementInfo info = JsonUtility.FromJson<ElementInfo>(text.text);
        return info;
    }

    public string getElementInfo(string element)
    {
        return (string) this.GetType().GetField(element).GetValue(this);
    }

}
