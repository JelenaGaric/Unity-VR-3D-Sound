using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public LayerMask movementMask;		// The ground

    PlayerMotor motor;

    Camera camera;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
        camera = Camera.main;
    }

    void Update()
    {
        // If we press left mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Shoot out a ray
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // If we hit
            if (Physics.Raycast(ray, out hit, movementMask))
            {
                motor.MoveToPoint(hit.point);

            }
        }

    }
}
