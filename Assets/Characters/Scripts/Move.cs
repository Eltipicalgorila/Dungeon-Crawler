using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 direcctionMove;
    [SerializeField] private float movementH,fowardMovement, velocity ;


    void Start()
    {
        rb=GetComponent<Rigidbody>();
        direcctionMove = new Vector3(movementH,0,fowardMovement);
    }


    void Update()
    {
        movementH = Input.GetAxis("Horizontal");
        fowardMovement = Input.GetAxis("Vertical");
        direcctionMove = new Vector3 (movementH, 0, fowardMovement);
    }
    private void FixedUpdate()
    {
        rb.AddForce(direcctionMove* velocity, ForceMode.VelocityChange);
    }
}
