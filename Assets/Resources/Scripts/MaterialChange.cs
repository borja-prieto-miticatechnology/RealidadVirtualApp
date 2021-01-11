using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public Material[] materialOFF;
    public Material[] materialON;

    public void BotonTechoOFF()
    {
        GetComponent<MeshRenderer>().materials = materialOFF;
    }

    public void BotonTechoON()
    {
        GetComponent<MeshRenderer>().materials = materialON;
    }
}
