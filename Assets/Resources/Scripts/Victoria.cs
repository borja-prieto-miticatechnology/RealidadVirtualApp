﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    public GameObject canvas;
    public GameObject cartel;
    public GameObject canvasFinal;
    public Text textoCartel;

    public GameObject siguiente3;
    public GameObject siguiente4;

    public GameObject gatillo;

    public GameObject fuegosArtif;
    public GameObject spawnFuegosArtif;
    
    public SteamVR_Fade FadeOut;

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
            StartCoroutine("CambiarAFinal");
            // this.gameObject.SetActive(false);
            // canvasFinal.gameObject.SetActive(true);
            // cartel.gameObject.SetActive(true);
            // textoCartel.text = Textos.texto12;
            VRTK.Examples.VRTKExample_PointerObjectHighlighterActivator.activarCrono = false;
            GameObject newFuegosArtif = (GameObject)Instantiate(fuegosArtif, spawnFuegosArtif.transform.position, spawnFuegosArtif.transform.rotation);
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
        StartCoroutine("SiguienteButton3");
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

    IEnumerator CambiarAFinal()
    {
        FadeOut.OnStartFade(Color.black, 2f, true);

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);

        yield return new WaitForSeconds(2f);
        StopCoroutine("CambiarAFinal");
    }

    IEnumerator SiguienteButton3()
    {
        textoCartel.text = Textos.texto5;
        gatillo.gameObject.SetActive(true);
        siguiente3.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        siguiente4.gameObject.SetActive(true);
        StopCoroutine("SiguienteButton3");
    }
}
