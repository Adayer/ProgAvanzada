using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo1 : MonoBehaviour
{
    VectorTres vec = new VectorTres(1,2,3); 

    void Start()
    {

    }
}


public struct VectorTres //: otra clase/struct-> Daria error porque los struct no pueden heredar de clases o estructuras
{
    public float x;
    public float y;
    public float z;

    public VectorTres(float x, float y, float z)//tienen que estar todas las variables
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}
