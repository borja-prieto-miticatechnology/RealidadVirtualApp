using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonCambiarEscena()
    {
        StartCoroutine("CambiarEscena");
        Debug.Log("pulso el boton");
    }

    public void BotonIrAMenu()
    {
        StartCoroutine("CambiarAMenu");
    }

    public void blabla()
    {
        Debug.Log("blabla");
    }

    IEnumerator CambiarEscena()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);

        yield return new WaitForSeconds(2f);
        StopCoroutine("CambiarEscena");
    }

    IEnumerator CambiarAMenu()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);

        yield return new WaitForSeconds(2f);
        StopCoroutine("CambiarAMenu");
    }
}
