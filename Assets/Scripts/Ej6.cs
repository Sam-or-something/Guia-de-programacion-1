using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6 : MonoBehaviour
{
    // Start is called before the first frame update
    //Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
    //en una variable llamada num1 y muestre un mensaje por pantalla indicando "el número es" o "el número es impar". 
    //Deberá utilizar el operador “módulo” es el caracter %.

    public int num1;

    void Start()
    {
        if (num1 <= 0)
        {
            Debug.Log("el numero debe ser mayor a 0");
        }
        else if (num1 % 2 == 1)
        {
            Debug.Log("el numero es impar");
        }
        else
        {
            Debug.Log("el numero es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
