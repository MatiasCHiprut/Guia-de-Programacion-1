//2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
//a.Suma
//b.Producto



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 4;
        int num2 = 5;
        int num3 = num1 + num2;
        int num4 = num1 * num2;
        Debug.Log(num1 + " + " + num2 + " = " + num3);
        Debug.Log(num1 + " x " + num2 + " = " + num4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
