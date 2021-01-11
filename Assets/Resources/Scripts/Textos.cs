using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    public GameObject canvas;
    public GameObject cartel;
    public GameObject siguiente;
    public GameObject siguiente1;
    public GameObject siguiente2;
    public Text textoCartel;

    public static string texto1 = "¡HOLA! Bienvenido al simulador de experiencias con Realidad Virtual con IMMERSE, creado por Mitica Technology. Utilice los gatillos traseros para seleccionar siguiente.";
    public static string texto2 = "Vamos a realizar una serie de actividades en un entorno virtual y queremos prepararte para que tu experiencia sea lo mejor posible, ¿preparado?";
    public static string texto3 = "Muevete por el edificio con los touchpad delanteros de los mandos hasta la flecha amarilla (Izquierdo: avanzar; derecho: rotar)";
    public static string texto4 = "¡Genial! Continuemos.";
    public static string texto5 = "Ahora vamos a coger algunos objetos. Localiza el cubo amarillo y recogele presionando el gatillo trasero del mando";
    public static string texto6 = "¡Perfecto! ¡Ya lo tienes! Empecemos con la formación";
    public static string texto7 = "Accede al cuadro de mandos pulsando el boton de menú y utiliza los botones para interactuar con el medio. Cuando haya terminado avance a la formación 2 a través del botón Empezar prueba.";
    public static string texto8 = "¡Perfecto! Primera parte de la formación con IMMERSE completada, pulse el boton de avance a formación 2 en el cuadro de mandos";
    public static string texto9 = "¡Atención! Ha saltado la alarma de deteccion de humos. Sigue las instrucciones que te mostraremos a continuación para llevar una correcta ejecución del plan de seguridad del edificio";
    public static string texto10 = "Localiza la bombona de oxigeno y cogela";
    public static string texto11 = "Dirigete hacia la salida por las escaleras, las flechas te indicarán el camino";
    public static string texto12 = "¡ENHORABUENA! ¡HAS COMPLETADO CON ÉXITO LA FORMACIÓN!";

    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(true);
        cartel.gameObject.SetActive(true);
        siguiente.gameObject.SetActive(true);
        textoCartel.text = texto1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void botonSiguiente()
    {
        textoCartel.text = texto2;
        siguiente.gameObject.SetActive(false);
        siguiente1.gameObject.SetActive(true);
    }

    public void botonSiguiente1()
    {
        textoCartel.text = texto3;
        siguiente1.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(true);
    }

    public void botonSiguiente2()
    {
        canvas.gameObject.SetActive(false);
        cartel.gameObject.SetActive(false);
        siguiente2.gameObject.SetActive(false);
    }
}
