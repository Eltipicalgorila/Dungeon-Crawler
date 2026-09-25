using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movimiento : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movimiento;
    public float velocidad;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");
         movimiento = new Vector3 (movimientoH, 0.0f, movimientoV);
        transform.Translate(Vector3.right * movimientoH * movimientoV*velocidad * Time.deltaTime);
    }
    private void FixedUpdate()
    {
     
    }

}
