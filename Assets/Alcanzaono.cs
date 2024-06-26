using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alcanzaono : MonoBehaviour
{
    public Producto producto = new Producto();
    public Precio cash = new Precio();
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

    
}
