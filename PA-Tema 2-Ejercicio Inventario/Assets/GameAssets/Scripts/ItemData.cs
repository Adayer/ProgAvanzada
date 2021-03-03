using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventarios 
{
    [CreateAssetMenu(fileName = "Item", menuName = "Items/new Item", order = 1)]
    public class ItemData : ScriptableObject
    {
        //Parámetros de los Items Scriptables
        public string m_nombre;
        public int m_coste;
        public Sprite m_image;
    }
}


