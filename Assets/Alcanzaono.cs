using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Alcanzaono : MonoBehaviour
{
    public Producto producto;
    public Precio cash;
    public Text JugarOtra;
    public GameObject panelNotificaciones;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void alcanza()
    {
        if (producto.precio < cash.presupuesto )
        {
            Debug.Log("Alcanza y sobra");
        }
    }

    public void Noalcanza() 
    { 
     if (producto.precio > cash.presupuesto)
        {
            Debug.Log("No alcanza");
        }
    }

    public void AlcanzaJusto() 
    { 
        if (producto.precio == cash.presupuesto)
        {
            Debug.Log("Alcanza justo");
        }
    }

      // Update is called once per frame
    void Update()
    {
        
    }

    public void JugarOtraVez()
    {
        //falta esto: if (resultado es correcto) { JugarOtra.text = "Reiniciar el desafío";}
        //else { JugarOtra.text = "Volver a intentarlo";}
        int resultado = 2; //esto se borra
        //en este if va si el resultado es correcto
        if (resultado == 3) {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            panelNotificaciones.SetActive(false);
        }
}

    public void Salir()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }

}
