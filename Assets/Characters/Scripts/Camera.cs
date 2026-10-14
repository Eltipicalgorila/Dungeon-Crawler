using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;
    private Vector3 Offset;
    void Start()
    {
        Offset = transform.position-Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position+ Offset;
    }
}
