//1. Realizá un programa donde se cree una variable entera llamada num1, que inicialmente  valdrá 0. 
//Luego incrementá su valor en 2 y mostralo por pantalla.
//Después mostrá el  resultado de multiplicarlo por sí mismo. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
            int num1 = 0;
            int num2 = num1 + 2;
            int num3 = num2 * 2;
            int num4 = num3 * 4;
            Debug.Log(num1 + " + 2 = " + num2);
            Debug.Log(num2 + " * 2 = " + num3);         
            Debug.Log(num3 + " * 4 = " + num4);
        }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
