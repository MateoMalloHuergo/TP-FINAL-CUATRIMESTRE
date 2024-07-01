using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Alcanzaono : MonoBehaviour
{
    public Precio cash;
    public Text JugarOtra;
    public GameObject panelNotificaciones;
    public Text textNotificaciones;
    bool resultado;
    // Start is called before the first frame update
    void Start()
    {
        panelNotificaciones.SetActive(false);
    }

    public void Alcanza()
    {
        //Si tu presupuesto es mayor que la suma de los productos. Se muestra el panel dependiendo de si tuviste razón o no.
        //Se activa al darle click al botón del UI
        if (cash.sumaprecio < cash.presupuesto) 
        {
            panelNotificaciones.SetActive(true);
            textNotificaciones.text = "RESULTADO CORRECTO";
            resultado = true;
            JugarOtra.text = "REINICIAR DESAFIO";
        }
        else
        {
            panelNotificaciones.SetActive(true);
            textNotificaciones.text = "RESULTADO INCORRECTO";
            resultado = false;
            JugarOtra.text = "VOLVER A INTENTARLO";
        }
    }

    public void NoAlcanza() 
    { 
        if (cash.presupuesto < cash.sumaprecio)
        {
            panelNotificaciones.SetActive(true);
            textNotificaciones.text = "RESULTADO CORRECTO";
            resultado = true;
            JugarOtra.text = "REINICIAR DESAFIO";
        }
        else
        {
            panelNotificaciones.SetActive(true);
            textNotificaciones.text = "RESULTADO INCORRECTO";
            resultado = false;
            JugarOtra.text = "VOLVER A INTENTARLO";
        }

    }

    public void AlcanzaJusto() 
    {
        if (cash.sumaprecio == cash.presupuesto)
        {
            panelNotificaciones.SetActive(true);
            textNotificaciones.text = "RESULTADO CORRECTO";
            resultado = true;
            JugarOtra.text = "REINICIAR DESAFIO";
        }
        else
        {
            panelNotificaciones.SetActive(true);
            textNotificaciones.text = "RESULTADO INCORRECTO";
            resultado = false;
            JugarOtra.text = "VOLVER A INTENTARLO";
        }
    }

      // Update is called once per frame
    void Update()
    {
        
    }

    public void JugarOtraVez()
    {
        // Si le das a volver a jugar despues del panel. Te lo vuelve a cargar.
        if (resultado) {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            panelNotificaciones.SetActive(false);
        }
}

    public void Salir()
    {
        // Si le das a Salir, te saca del juego. Cambiando de escena.
        SceneManager.LoadScene("SeleccionarJuegos");
    }

}
