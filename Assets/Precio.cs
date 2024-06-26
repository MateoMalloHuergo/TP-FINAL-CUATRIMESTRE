using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Precio : MonoBehaviour
{
    public Producto producto;
    public Text presupuestoTexto; 

    // Start is called before the first frame update
    void Start()
    {
        int presupuesto = Random.Range(10, 50);
        presupuestoTexto.text = "Presupuesto: " + presupuesto.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
