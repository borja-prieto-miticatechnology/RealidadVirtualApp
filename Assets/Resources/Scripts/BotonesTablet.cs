using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesTablet : MonoBehaviour
{
    public Material[] materialOFF;
    public Material[] materialON;

    public GameObject techo;
    public GameObject props;

    public GameObject ventilacion;
    public GameObject tuberias;
    public GameObject cables;
    public GameObject fuego;
    public GameObject spawn;
    public GameObject canvas;
    public GameObject cartel;
    public GameObject siguiente7;
    public GameObject siguiente8;
    public GameObject tablet;
    public GameObject mascara;

    public Text textoCartel;

    public bool statusVentilacion;
    public bool statusTuberias;
    public bool statusCables;

    // Start is called before the first frame update
    void Start()
    {
       // BotonFormacion2();
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public void BotonVentilacion()
    {
        if (statusVentilacion == true)
        {
            statusVentilacion = false;
            ventilacion.SetActive(statusVentilacion);
        }
        else
        {
            statusVentilacion = true;
            ventilacion.SetActive(statusVentilacion);
        }
    }

    public void BotonTuberias()
    {
        if (statusTuberias == true)
        {
            statusTuberias = false;
            tuberias.SetActive(statusTuberias);
        }
        else
        {
            statusTuberias = true;
            tuberias.SetActive(statusTuberias);
        }
    }

    public void BotonCables()
    {
        if (statusCables == true)
        {
            statusCables = false;
            cables.SetActive(statusCables);
        }
        else
        {
            statusCables = true;
            cables.SetActive(statusCables);
        }
    }

    public void BotonFormacion2()
    {
        GameObject newFuego = (GameObject)Instantiate(fuego, spawn.transform.position, spawn.transform.rotation);
        canvas.gameObject.SetActive(true);
        tablet.gameObject.SetActive(false);
        cartel.gameObject.SetActive(true);
        siguiente7.gameObject.SetActive(true);
        textoCartel.text = Textos.texto9;
        BotonTechoON();
    }

    public void botonSiguiente7()
    {
        textoCartel.text = Textos.texto10;
        siguiente7.gameObject.SetActive(false);
        siguiente8.gameObject.SetActive(true);
        mascara.gameObject.SetActive(true);
    }
    public void botonSiguiente8()
    {
        canvas.gameObject.SetActive(false);
        cartel.gameObject.SetActive(false);
        siguiente8.gameObject.SetActive(false);
    }

    public void BotonTechoOFF()
    {
        techo.GetComponent<MeshRenderer>().materials = materialOFF;
        //techo.GetComponent<MeshRenderer>().materials[10] = TransparentTechoMaterial;
        props.gameObject.SetActive(false);
    }

    public void BotonTechoON()
    {
        techo.GetComponent<MeshRenderer>().materials = materialON;
       // techo.GetComponent<MeshRenderer>().materials[10] = OriginalTechoMaterial;
        props.gameObject.SetActive(true);
    }
}
