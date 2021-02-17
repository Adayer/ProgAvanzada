using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo3 : MonoBehaviour
{
    void Start()
    {
        ImBored iB = new ImBored();
        iB.CurrentSanity -= 99;
        print(iB.CurrentSanity);
    }
}


public class ImBored
{
    private float m_currentSanity = 100f;

    public float CurrentSanity { 
        get {
            Debug.LogError("Do you really want to bother me?");
            return m_currentSanity;
        }
        set {
            Debug.LogError("Are you sure about that??");
            if(m_currentSanity < 0f)
            {
                m_currentSanity = 0f;
            }
            else if(m_currentSanity >= 100f)
            {
                m_currentSanity = 100f;
            }
            m_currentSanity = value;
        }
    }
}
