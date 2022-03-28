using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//crear 3 variabes publicas enteras chequear si los 3 valores son iguales, si lo son mostrar en consola "son los 3 iguales si no lo son mostrar cual es el mayor
public class comparacionnumeros : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1 = 5;
    public int num2 = 2;
    public int num3 = 8;
    void Start()
    {
        if (num1 == num2 && num2 == num3)
        {
            Debug.Log("Los 3 numeros son iguales");
        }
        else if (num1 > num2 && num1 > num3)
        {
            Debug.Log("Los 3 numeros no son iguales, siendo " + num1 + " el mayor");
        }
        else if(num1<num2 && num2>num3)
        {
            Debug.Log("Los 3 numeros no son iguales, siendo " + num2 + " el mayor");
        }
        else if(num1<num3 && num2<num3)
        {
            Debug.Log("Los 3 numeros no son iguales, siendo " + num3 + " el mayor");
        }
        else
        {
            Debug.Log("Hay 2 numeros que son iguales");
        }
    }

}
