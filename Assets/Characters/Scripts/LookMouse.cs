
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float sensitivity;
    public Transform player;
    private float horizontalRotation = 0;
    private float verticalRotation = 0;

    void Start()
    {

    }

    void Update()
    {
        float ValorX= Input.GetAxis("Mouse X")* sensitivity * Time.deltaTime;
        float ValorY= Input.GetAxis("Mouse Y")* sensitivity * Time.deltaTime;

        horizontalRotation = ValorX;
        verticalRotation -= ValorY;

        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        player.Rotate(Vector3.up * horizontalRotation);

        Debug.Log($"MouseEnX={ValorX:F1},MouseEnY={ValorY:F1}");
    }
}
