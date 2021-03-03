using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventarios
{
    [System.Serializable]
    public class Item
    {
        //Parámetros item
        public string itmName;
        public Sprite image;

        [SerializeField]
        private int _cost;
        public int cost {
            get {
                return _cost;
            }
            //Devolver el valor correcto
            set {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 999)
                {
                    value = 999;
                }
                
                _cost = value;
            }//Añadir mínimo y máximo valor respectivamente (0,999).
        }

        //Usar el constructor para crear las instancias de los objetos a partir de los objetos scriptables

       public Item(ItemData itemData)
       {
            cost = itemData.m_coste;
            itmName = itemData.m_nombre;
            image = itemData.m_image;
       }

        public void UseItem()
        {
            //Añadir el oro de la venta a la variable de oro total del inventario
            Inventory._instance.AddGold(_cost);
            Debug.Log("El objeto " + itmName + " ha sido vendido por un valor total de: " + cost);//Info por consola de la venta
        }
    }
}


