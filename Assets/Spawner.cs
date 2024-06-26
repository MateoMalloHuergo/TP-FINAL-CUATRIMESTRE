using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obj = new GameObject[6];
    public int numobj;
    public int numobj2;


    // Start is called before the first frame update
    void Start()
    {
        Alimento1();
        Alimento2();
    }

    public void Alimento1()
    {
        numobj = Random.Range(0, obj.Length);
        Vector3 Posicion1 = new Vector3(-4, 0, 0.2f);
        Instantiate(obj[numobj], Posicion1, Quaternion.identity);
    }

    public void Alimento2()
    {
        numobj2 = Random.Range(0, obj.Length);
        Vector3 Posicion2 = new Vector3(4, 0, 0.2f);
        Instantiate(obj[numobj2], Posicion2, Quaternion.identity);
    }
}