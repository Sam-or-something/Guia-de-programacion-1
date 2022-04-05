using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8 : MonoBehaviour
{
    // Start is called before the first frame update
    //Crear una variable entera que pueda ser modificada desde el Inspector. 
    //Suponiendo que el primer día de la semana es el Domingo, 
    //mostrar el nombre del día correspondiente al valor de la variable “dia”. 
    //Si el día no está en el rango  permitido debe emitir por pantalla el mensaje de error "
    //El día ingresado no es válido". 
    public int dia;
    void Start()
    {
        if (dia == 1)
        {
            Debug.Log("domingo");
        }
        else if (dia == 2)
        {
            Debug.Log("lunes");
        }
        else if (dia == 3)
        {
            Debug.Log("martes");
        }
        else if (dia == 4)
        {
            Debug.Log("miercoles");
        }
        else if (dia == 5)
        {
            Debug.Log("jueves");
        }
        else if (dia == 6)
        {
            Debug.Log("viernes");
        }
        else if (dia == 7)
        {
            Debug.Log("sabado");
        }
        else
        {
            Debug.Log("el dia ingresado no es valido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
