using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;

    private CharacterController controller;
    private Transform camara;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        camara = Camera.main.transform;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 adelante = camara.forward;
        Vector3 derecha = camara.right;

        adelante.y = 0f;
        derecha.y = 0f;

        adelante.Normalize();
        derecha.Normalize();

        Vector3 movimiento =
            adelante * vertical + derecha * horizontal;

        movimiento = Vector3.ClampMagnitude(movimiento, 1f);

        controller.Move(movimiento * velocidad * Time.deltaTime);
    }
}
