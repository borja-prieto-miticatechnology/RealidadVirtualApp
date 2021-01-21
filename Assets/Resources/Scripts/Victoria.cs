using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    public GameObject canvas;
    public GameObject cartel;
    public Text textoCartel;

    public GameObject siguiente3;
    public GameObject siguiente4;

    public GameObject gatillo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "victoria")
        {
            botonCambiarAMenu();
            this.gameObject.SetActive(false);
            canvas.gameObject.SetActive(true);
            cartel.gameObject.SetActive(true);
            textoCartel.text = Textos.texto12;
            VRTK.Examples.VRTKExample_PointerObjectHighlighterActivator.activarCrono = false;
        }

        else if (this.gameObject.tag == "flecha")
        {
            this.gameObject.SetActive(false);
            canvas.gameObject.SetActive(true);
            cartel.gameObject.SetActive(true);
            siguiente3.gameObject.SetActive(true);
            textoCartel.text = Textos.texto4;
        }

        else if (this.gameObject.tag == "guia")
        {
            this.gameObject.SetActive(false);
        }
    }

    public void botonSiguiente3()
    {
        textoCartel.text = Textos.texto5;
        siguiente3.gameObject.SetActive(false);
        siguiente4.gameObject.SetActive(true);
        gatillo.gameObject.SetActive(true);
    }

    public void botonSiguiente4()
    {
        canvas.gameObject.SetActive(false);
        cartel.gameObject.SetActive(false);
        siguiente4.gameObject.SetActive(false);
        gatillo.gameObject.SetActive(false);
    }

    public void botonCambiarAMenu()
    {
        StartCoroutine("CambiarAMenu");
    }

    IEnumerator CambiarAMenu()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);

        yield return new WaitForSeconds(2f);
        StopCoroutine("CambiarAMenu");
    }
}
