using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    private float horizantalInput;
    private float verticalInput;
    public float speed = 5.0f;
    public Rigidbody rb;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        horizantalInput = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.back * horizantalInput * speed * Time.deltaTime, ForceMode.Impulse);
        verticalInput = Input.GetAxis("Vertical");
        rb.AddForce(Vector3.right * verticalInput * speed * Time.deltaTime , ForceMode.Impulse);
    }
}
