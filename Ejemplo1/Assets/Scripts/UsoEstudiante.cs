using UnityEngine;
using System;
using packagePersona;
using NUnit.Framework;
using System.Collections.Generic;

public class UsoEstudiante : MonoBehaviour
{
    List<Estudiante> listaE =new List<Estudiante>();




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Estudiante e1 = new Estudiante("2025_03", "Ing multimedia", "David Castro", "dacastro@uao.co", "carrera 34");
        Estudiante e2 = new Estudiante("2025_03", "Ing ambiental", "Maria Perez", "dacastro@uao.co", "carrera 34");

        listaE.Add(e1);
        listaE.Add(e2);

        for (int i = 0;)
        {
            Debug.Log("name ");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
