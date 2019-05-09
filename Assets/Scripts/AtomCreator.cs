using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomCreator : MonoBehaviour
{

    int protons = 0;
    int electrons = 0;
    int neutrons = 0;

    private List<GameObject> particles;

    public Transform positionObject;

    private void Start()
    {
        this.particles = new List<GameObject>();
    }

    private void CreateAtom()
    {
        particles = new List<GameObject>();

        GameObject nucleus = new GameObject();
        nucleus.transform.position = positionObject.transform.position;
        nucleus.name = "nucleus";
        particles.Add(nucleus);
        for (int i = 0; i < protons; i++)
        {
            GameObject proton = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            proton.transform.parent = nucleus.transform;
            //proton.transform.localPosition = new Vector3(i, i, i);
            proton.transform.localPosition = new Vector3(Random.value * (i/2), Random.value * (i/2), Random.value * (i/2));
            proton.transform.localScale = new Vector3(4, 4, 4);
            proton.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Holograms/3DObjects/proton");
            proton.AddComponent(typeof(FadeMaterial));
            proton.name = "proton" + i;
            particles.Add(proton);
        }

        for (int i = 0; i < neutrons; i++)
        {
            GameObject neutron = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            neutron.transform.parent = nucleus.transform;
            //neutron.transform.localPosition = new Vector3(i + 1, i + 1, i + 1);
            neutron.transform.localPosition = new Vector3(Random.value * (i/2), Random.value * (i/2), Random.value * (i/2));
            neutron.transform.localScale = new Vector3(4, 4, 4);
            neutron.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Holograms/3DObjects/neutron");
            neutron.AddComponent(typeof(FadeMaterial));
            neutron.name = "neutron" + i;
            particles.Add(neutron);
        }

        int shell = 10;
        for (int i = 0; i < electrons; i++)
        {
            if (i == 2|| i==8||i==18)
            {
                shell+=3; // Increase the shell ring that the electrons will be found at
            }

            GameObject rotator = new GameObject();
            rotator.name = "electronRotator" + i;
            rotator.AddComponent(System.Type.GetType("ElectronMover"));
            rotator.transform.position = this.positionObject.position;
            particles.Add(rotator);

            GameObject electron = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            electron.transform.parent = rotator.transform;
            electron.transform.localPosition = new Vector3(shell, 0, 0);
            electron.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Holograms/3DObjects/electron");
            electron.AddComponent(typeof(FadeMaterial));
            electron.name = "electron" + i;
            particles.Add(electron);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayElement(int protons, int electrons, int neutrons)
    {
        StartCoroutine(displayCoroutine(protons, electrons, neutrons));
    }

    public void destroyElement()
    {
        StartCoroutine(destroyCoroutine());
    }

    IEnumerator displayCoroutine(int protons, int electrons, int neutrons)
    {
        if (particles.Count > 0) {
            foreach (GameObject particle in particles)
            {
                FadeMaterial fader = particle.GetComponent<FadeMaterial>();
                if (fader != null)
                    fader.FadeOut();
            }
            yield return new WaitForSeconds(1);
            foreach (GameObject particle in particles)
            {
                Destroy(particle);
            }
        }
        this.protons = protons;
        this.electrons = electrons;
        this.neutrons = neutrons;
        this.CreateAtom();
    }

    IEnumerator destroyCoroutine()
    {
        foreach (GameObject particle in particles)
        {
            FadeMaterial fader = particle.GetComponent<FadeMaterial>();
            if (fader != null)
                fader.FadeOut();
        }
        yield return new WaitForSeconds(1);
        foreach (GameObject particle in particles)
        {
            Destroy(particle);
        }
        particles = new List<GameObject>();
    }
}
