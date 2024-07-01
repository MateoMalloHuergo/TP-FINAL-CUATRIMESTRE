using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obj = new GameObject[6];
    int numobj;
    int numobj2;
    public int num1;
    public int num2;


    // Start is called before the first frame update
    void Start()
    {
        // Se ejecutan los voids Alimento1 y Alimento2.
        Alimento1();
        Alimento2();
    }

    public void Alimento1()
    {
        // Numobj obtiene un valor random para que asi aparezcan alimentos de manera random.
        numobj = Random.Range(0, obj.Length -1 );
        num1 = numobj;
        // Se determina la posicion de aparicion de los alimentos. Tambien spawnean en la pantalla utilizando la funcion Instantiate.
        Vector3 Posicion1 = new Vector3(-4, 0, 0.2f);
        Instantiate(obj[numobj], Posicion1, Quaternion.identity).SetActive(true);
    }

    public void Alimento2()
    {
        // Numobj obtiene un valor random para que asi aparezcan alimentos de manera random.
        numobj2 = Random.Range(0, obj.Length);
        num2 = numobj2;
        // Se determina la posicion de aparicion de los alimentos. Tambien spawnean en la pantalla utilizando la funcion Instantiate.
        Vector3 Posicion2 = new Vector3(4, 0, 0.2f);
        Instantiate(obj[numobj2], Posicion2, Quaternion.identity).SetActive(true); ;
    }
}