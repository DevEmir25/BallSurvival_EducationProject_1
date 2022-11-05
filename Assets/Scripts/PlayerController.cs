using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;  // Disardan ulasmak icin nesne olusturuyoruz..
    private float horizantalInput;  // yatay girdi almak icin degisken atýyoruz
    private float verticalInput;  // dikey girdi almak icin degisken atiyoruz
    public float speed = 5.0f;  // player objemiz icin hýz degiskeni belirliyoruz
    public Rigidbody rb; // Player objemizin fizigine etki etmek icin rigidbody componentini cekiyoruz

    private void Awake()  // Program basladiginda calisan metotumuz
    {
        Instance = this;
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); // Atadýgýmýz degiskenin dikey girdisini almak icin yazilan kod
        rb.AddForce(Vector3.forward * verticalInput * speed * Time.deltaTime, ForceMode.Impulse); //girdiyi aldigimizda topu ileri ve geri kuvvet ile hareket ettirdigimiz kod
        horizantalInput = Input.GetAxis("Horizontal");  // Atadýgýmýz degiskenin yatay girdisini almak icin yazilan kod
        rb.AddForce(Vector3.right * horizantalInput * speed * Time.deltaTime , ForceMode.Impulse); //girdiyi aldigimizda topu sag ve sol kuvvet ile hareket ettirdigimiz kod
    }
}
