using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Precio : MonoBehaviour
{
    public Spawner spawn;
    int[] precioprod = new int [7];
    public Text presupuestoTexto;
    public Text Alimento1;
    public Text Alimento2;
    public int presupuesto;
    public int sumaprecio;
    
    // Start is called before the first frame update
    void Start()
    {
        // Presupuesto obtiene un valor random entre los dos valores.
        presupuesto = Random.Range(30, 60);
        
        presupuestoTexto.text = "PRESUPUESTO: " + presupuesto.ToString();
        
        // Lista con los precios de cada producto.
        precioprod[0] = 30;
        precioprod[1] = 20;
        precioprod[2] = 15;
        precioprod[3] = 25;
        precioprod[4] = 15;
        precioprod[5] = 15;
        precioprod[6] = 10;
       
        // Suma de ambos precios para despues compararlos con el presupuesto.
        sumaprecio = precioprod[spawn.num1] + precioprod[spawn.num2];
        
        // Cambiamos el valor de precioprod a un string para poder ponerlo en un texto.
        string precio1 = precioprod[spawn.num1].ToString();
        string precio2 = precioprod[spawn.num2].ToString();

        // Actualiza los textos de Alimento1 y Alimento2 con los precios correctos
        Alimento1.text = "PRECIO: " + precio1;
        Alimento2.text = "PRECIO: " + precio2;
        //Alimento2.text = "Precio: " + precioprod[spawn.num2].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ///Alimento1.text = "Precio: " + precioprod[spawn.num1];
        //Alimento2.text = "Precio: " + precioprod[spawn.num2];
    }
}
