using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atomCreation : MonoBehaviour
{

    int protons=1;
    int neutrons=1;
    int electrons=2;
    // Start is called before the first frame update
    void Start()
    {

        /*
        for (int i = 0; i < protons; i++)
        {
            
            GameObject proton = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            proton.transform.position = new Vector3(i, i, i);

            GameObject neutron = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            neutron.transform.position = new Vector3(i+1, i+1, i+1);

        }

        int shell = 3;
        for (int i = 0; i < electrons; i++)
        {
            if (i == 2|| i==8||i==18)
            {
                shell+=3; // Increase the shell ring that the electrons will be found at
            }

            GameObject electron = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            electron.transform.position = new Vector3(shell, 0, 0);
         
            
        }
 */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
