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

public struct VectorDos
{
    public float x;
    public float y;
}

public struct VectorTres //: otra clase/struct-> Daria error porque los struct no pueden heredar de clases o estructuras
{
    public VectorDos coor;    
    public float z;

    public VectorTres(float x, float y, float z)//tienen que estar todas las variables
    {
        coor.x = x;
        coor.y = y;
        this.z = z;
    }
}
