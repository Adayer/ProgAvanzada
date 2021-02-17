using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo2 : MonoBehaviour
{

    [SerializeField] private States estadoActual = States.Bleed;
    

    void Start()
    {
        estadoActual = States.Dead;
        print((int)estadoActual);//prints 1
        estadoActual = (States)0;
        print(estadoActual);//prints Poisoned
    }
}
public enum States {Poisioned, Dead, Bleed, Fear, Normal}
