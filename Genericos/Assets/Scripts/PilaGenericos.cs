using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilaGenericos : MonoBehaviour
{
    GenericPile<Enemy> enemigo = new GenericPile<Enemy>();
    //GenericPile<Village> villager = new GenericPile<Villager>(); --- DA ERROR PORQUE NO IMPLEMENTA IDAMAGEABLE

    private void Start()
    {
        Miniom m1 = new Miniom("Peter");
        m1.TakeDamage(Random.Range(0,101));
        Miniom m2 = new Miniom("Bob");
        m2.TakeDamage(Random.Range(0,101));
        Miniom m3 = new Miniom("Ralph");
        m3.TakeDamage(Random.Range(0,101));
        Boss b1 = new Boss("Big Booty Bitches");
        b1.TakeDamage(Random.Range(0,101));
        
        enemigo.AddItem(b1);
        enemigo.AddItem(m1);
        enemigo.AddItem(m2);
        enemigo.AddItem(m3);

        print("Vene el enemigo " + enemigo.GetBottom().name);
        print("Vene el enemigo " + enemigo.GetBottom().name);
        print("Vene el enemigo " + enemigo.GetBottom().name);
        print("Vene el enemigo " + enemigo.GetBottom().name);
    }
}

public class GenericPile<T> where T : class, IDamageable
{
    public Node head;
    public Node Head
    {
        get
        {
            return head;
        }
    }
    public Node bottom;
    public Node Bottom
    {
        get
        {
            return bottom;
        }
    }

    public class Node{
        public T data;
        public Node next;
        public Node previous;

        public Node(T t)
        {
            next = null;
            previous = null;
            data = t;
        }
    }

    public GenericPile()
    {
        head = null;
    }

    public void AddItem(T t)
    {
        Node n = new Node(t);
        n.next = head;
        if (n.next != null)
        {
            head.previous = n;
        }
        else {
            bottom = n;
        }
        head = n;
    }

    public T GetHead()
    {
        T data = head.data;
        head = head.next;
        head.next.previous = null;
        return data;
    }
    public T GetBottom()
    {
        T data = bottom.data;
        bottom = bottom.previous;
        bottom.previous.next = null;
        return data;
    }
}


public interface IDamageable
{
    void TakeDamage(int amount);
    void Die();
}
public class Villager
{

}

public class Enemy : IDamageable
{
    public int vida = 100;
    public string name = "";

    public void Die()
    {
        Debug.Log("Aaaaah me muero");
    }

    public void TakeDamage(int amount)
    {
        vida -= amount;
        vida = Mathf.Clamp(vida, 0, 100);
    }

    public Enemy(string _name)
    {
        name = _name;
    }
}

public class Boss : Enemy
{
    public Boss(string _name) : base(_name)
    {

    }
}
public class Miniom : Enemy
{
    public Miniom(string _name) : base(_name)
    {

    }
}