using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody Rb;
    Vector3 moveImput;
    void Start()
    {
        Rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveImput =Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            moveImput.z = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveImput.z = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveImput.x = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveImput.x = -1;
        }
    }
    private void FixedUpdate()
    {
        Move(moveImput);
    }
    void Move(Vector3 direction) 
    {
        Rb.AddForce(direction.normalized * speed * ForceMode.Acceleration);
    }

}
