using UnityEngine;

[System.Serializable]
public class ElementInfo
{
    public string hydrogen;
    public string helium;
    public string lithium;
    public string beryllium;
    public string boron;
    public string carbon;
    public string nitrogen;
    public string oxygen;
    public string fluorine;
    public string neon;
    public string sodium;
    public string magnesium;
    public string aluminum;
    public string silicon;
    public string phosphorous;
    public string sulfur;
    public string chlorine;
    public string argon;
    public string potassium;
    public string calcium;

    public string water;
    public string co2;
    public string glucose;

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
