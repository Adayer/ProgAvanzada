using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Inventarios {
    public class Inventory : MonoBehaviour
    {
        //Acceso estático

        //Referencias UI
        [SerializeField]
        private Transform content;
        [SerializeField]
        private Text goldTxt;

        private int totalGold = 0;

        //Referencia al prefab del Botón Item
        [SerializeField]
        private GameObject itemBtnPref;


        public List<Item> bag = new List<Item>();


        public static Inventory _instance;
             
        public int TotalGold { get => totalGold;
            set {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 9999)
                {
                    value = 9999;
                } 
                 totalGold = value;} }

        private void Awake()
        {
            //Referencia estática... instance = this
            if(_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                print(_instance);
                Destroy(this.gameObject);
            }
        }

        private void Start()
        {
            AddRandomItems(10);
            bag[2].cost = 100000; //Si se usa la propiedad cost correctamente el máximo se quedaría en 999
        }

        void ShowItem(Item item)
        {
            GameObject go = Instantiate(itemBtnPref, content);
            go.GetComponent<ItemButton>().item = item;
        }

        private void AddRandomItems(int amount)
        {
            ItemData[] itemsData = Resources.LoadAll<ItemData>("Items/");
            for (int i = 0; i < amount; i++) {

                //Nota: Descomentar las 3 lineas de codigo cuando esté creado el constructor de Item

                ItemData data = itemsData[Random.Range(0, itemsData.Length)]; //coge un objeto scriptable aleatorio de resources
                Item item = new Item(data); //Instancia un objeto Item construido a partir de los datos del objeto scriptado
                AddItem(item); //Añade el Item
            }
        }

        public void AddGold(int amount)
        {
            TotalGold += amount;

            goldTxt.text = TotalGold.ToString();
        }

        public void AddItem(Item newItem)
        {
            bag.Add(newItem);
            ShowItem(newItem);
        }
    }
}


