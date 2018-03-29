using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

    public Color emissioncolor = new Color(0.3970588f, 0.09634516f, 0.3016601f);

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            Material Othermaterial = other.gameObject.GetComponent<MeshRenderer>().materials[0];
            Othermaterial.SetColor("_EmissionColor", emissioncolor);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            Material Othermaterial = other.gameObject.GetComponent<MeshRenderer>().materials[0];
            Othermaterial.SetColor("_EmissionColor", Color.black);
        }
    }
}
