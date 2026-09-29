using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject Jugador;
    private Vector3 Offset;
    void Start()
    {
        Offset = transform.position-Jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position+ Offset;
    }
}
