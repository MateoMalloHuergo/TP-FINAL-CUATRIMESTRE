﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarAlimento : MonoBehaviour
{
    public Spawner spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambioDeAlimento()
    {
        Destroy(spawn.obj[spawn.num1]);
        Destroy(spawn.obj[spawn.num2]);
        spawn.Alimento1();
        spawn.Alimento2();
    }
}