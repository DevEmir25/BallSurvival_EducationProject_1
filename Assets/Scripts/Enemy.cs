using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    public float speed = 1000;
    void Start()
    {
        rb = GetComponent<Rigidbody>();  //dusmanin fizigini kodlamak �zere rigidbodysini kod �zerinden cekiyoruz.
        player = GameObject.FindWithTag("Player"); //Player tagini verdigimiz kendimizi kod uzerinden cekmek icin tanimliyoruz.
    }

    void Update()
    {
        rb.AddForce(GetPosition() * speed * Time.deltaTime, ForceMode.Force); //Tanimladigimiz rb'ye Add force ile kuvvet uyguluyoruz
    }
    
    Vector3 GetPosition() //Kendi konumumuzu d�smanin konumundan cikardigimizda elde ettigimiz yeni konum icin metot yaz�yoruz.
    {
        return player.transform.position - gameObject.transform.position;
    }
}
