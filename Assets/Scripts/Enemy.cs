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
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        rb.AddForce(GetPosition() * speed * Time.deltaTime, ForceMode.Force);
    }
    /// <GetPosition>
    /// oyuncunun d�?man karaktere g�re konumunu d�nd�r�r
    /// </GetPosition>
    /// <returns>vector 3 konum d�nd�r�r</returns>
    Vector3 GetPosition()
    {
        return player.transform.position - gameObject.transform.position;
    }
}
