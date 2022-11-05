using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;  // Disardan ulasmak icin nesne olusturuyoruz..
    private float horizantalInput;  // yatay girdi almak icin degisken at�yoruz
    private float verticalInput;  // dikey girdi almak icin degisken atiyoruz
    public float speed = 5.0f;  // player objemiz icin h�z degiskeni belirliyoruz
    public Rigidbody rb; // Player objemizin fizigine etki etmek icin rigidbody componentini cekiyoruz

    private void Awake()  // Program basladiginda calisan metotumuz
    {
        Instance = this;
    }

    void Update()
    {
        horizantalInput = Input.GetAxis("Horizontal");  // Atad�g�m�z degiskenin yatay girdisini almak icin yazilan kod
        rb.AddForce(Vector3.back * horizantalInput * speed * Time.deltaTime, ForceMode.Impulse); // yatay girdi aldigimizda rigidbody componentine kuvvet uyguluyoruz
        verticalInput = Input.GetAxis("Vertical"); // Atad�g�m�z degiskenin dikey girdisini almak icin yazilan kod
        rb.AddForce(Vector3.right * verticalInput * speed * Time.deltaTime , ForceMode.Impulse); // dikey girdi aldigimizda rigidbody componentine kuvvet uyguluyoruz
    }
}
