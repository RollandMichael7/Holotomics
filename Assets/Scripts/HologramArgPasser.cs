using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HologramArgPasser : MonoBehaviour
{
    public int protons;
    public int electrons;
    public int neutrons;

    private Button b;

    // Start is called before the first frame update
    void Start()
    {
        b = this.GetComponent<Button>();
        b.onClick.AddListener(() => displayElement());
    }

    private void displayElement()
    {
        GameObject hologramObject = GameObject.Find("AtomCreator");
        AtomCreator hologram = hologramObject.GetComponent<AtomCreator>();
        hologram.displayElement(protons, electrons, neutrons);
    }
}
