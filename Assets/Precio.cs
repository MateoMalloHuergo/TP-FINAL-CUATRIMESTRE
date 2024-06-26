using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Precio : MonoBehaviour
{
    public Spawner spawn;
    public int[] precioprod;
    public Text presupuestoTexto;
    public Text Alimento1;
    public Text Alimento2;
    public int presupuesto = Random.Range(10, 50);
    int sumaprecio;
    
    // Start is called before the first frame update
    void Start()
    {
        presupuestoTexto.text = "Presupuesto: " + presupuesto.ToString();
        precioprod[0] = 30;
        precioprod[1] = 20;
        precioprod[2] = 15;
        precioprod[3] = 25;
        precioprod[4] = 15;
        precioprod[5] = 15;
        precioprod[6] = 10;
        sumaprecio = precioprod[spawn.num1] + precioprod[spawn.num2];
        //Alimento1.text = "Precio: " + precioprod[spawn.num1];
        //Alimento2.text = "Precio: " + precioprod[spawn.num2];
    }

    // Update is called once per frame
    void Update()
    {
        Alimento1.text = "Precio: " + precioprod[spawn.num1];
        Alimento2.text = "Precio: " + precioprod[spawn.num2];
    }
}
